using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   

    public InputManager inputManager;
    public PlayerData playerData;
    public Rigidbody rb;
    bool facingRight = true;
    bool movingRight = false;
    bool movingLeft = false;

    bool onGround = true;
    bool justJumped = false;

    
    bool hasDoubleJumped = false;
    bool hasDashed = false;
    bool isDashing = false;

    bool hasWallJumped = false;
    bool isWallJumping = false;

    bool isLedgeGrabing = false;
    bool justLedgeGrabbed = false;

    public List<Transform> groundChecks;
    public LayerMask groundLayer;

    public Transform wallCheck;
    public Transform ledgeCheck;

    public VoidEventChannel deathEvent;

    [Header("Active Powerups")]
    public bool canDoubleJump = false;
    public bool canFly = false;
    public bool canDash = false;
    public bool canWallJump = false;
    public bool canLedgeGrab = false;

    [Header("Powerup Events")]
    public VoidEventChannel doubleJumpEvent;
    public VoidEventChannel dashEvent;
    public VoidEventChannel wallJumpEvent;
    public VoidEventChannel ledgeGrabEvent;
    public VoidEventChannel flyEvent;
    public VoidEventChannel powerUPEvent;

    public Animator animator;

    public AudioManager audioManager;

    public bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        inputManager.Spacebar += Jump;
        inputManager.Right += MoveRight;
        inputManager.Left += MoveLeft;
        inputManager.Dash += Dash;
        inputManager.UpDown += Fly;
        inputManager.UpDownEnd += FlyStop;

        doubleJumpEvent.VoidEvent += DoubleJumpPowerUp;
        dashEvent.VoidEvent += DashPowerUp;
        wallJumpEvent.VoidEvent += WallJumpPowerUp;
        ledgeGrabEvent.VoidEvent += LedgeGrabPowerup;
        flyEvent.VoidEvent += FlyPowerup;

        deathEvent.VoidEvent += OnDeath;
    }

    // Update is called once per frame
    void Update()
    {

        AnimatorUpdate();

        if (!canMove)
        {
            return;
        }

        if (isLedgeGrabing)
        {
            
            return;
        }

        if (canLedgeGrab)
        {
            if (!onGround && !justLedgeGrabbed)
            {
                Ray ray = new Ray(ledgeCheck.position, ledgeCheck.forward);
                if (Physics.Raycast(ray, playerData.groundCheckLength, groundLayer))
                {
                    rb.isKinematic = true;
                    isLedgeGrabing = true;
                }
            }
        }



        Move();

        if (!justJumped)
        {
            GroundCheck();
        }


    }

    public void Move()
    {
        if (isDashing || isWallJumping)
        {
            return;
        }
        if (movingRight)
        {
            rb.velocity = Utils.ChangeVector3Value(rb.velocity, Utils.Position.x, playerData.maxSpeed);
        }
        else if (movingLeft)
        {
            rb.velocity = Utils.ChangeVector3Value(rb.velocity, Utils.Position.x, -playerData.maxSpeed);
        }
        else
        {
            rb.velocity = Vector3.Lerp(rb.velocity, new Vector3(0, rb.velocity.y, 0), playerData.speedDampening);
        }


    }

    public void Turn()
    {
        transform.Rotate(transform.up, 180f);
        facingRight = !facingRight;
    }

    public void MoveRight(bool value)
    {
        movingRight = value;

        if (value)
        {
            if (!facingRight)
            {
                Turn();
            }
        }

        
    }

    

    public void MoveLeft(bool value)
    {
        movingLeft = value;

        if (value)
        {
            if (facingRight)
            {
                Turn();
            }
        }


    }


    void GroundCheck()
    {

        bool oldGround = onGround;
        foreach(Transform groundCheck in groundChecks)
        {
            RaycastHit hitInfo;

            Ray ray = new Ray(groundCheck.position, groundCheck.forward);

            Debug.DrawLine(groundCheck.position, groundCheck.position+groundCheck.forward * playerData.groundCheckLength, Color.red) ;

            if(Physics.Raycast(ray, out hitInfo, playerData.groundCheckLength, groundLayer))
            {

                onGround = true;
                hasDoubleJumped = false;
                hasWallJumped = false;
                rb.useGravity = true;

                if (!oldGround)
                {
                    audioManager.PlayGroundTouch();
                }

                return;
            }
            else
            {
                onGround = false;
            }
        }


    }

    public void Jump(bool value)
    {
        if (!canMove)
        {
            return;
        }

        if (!onGround)
        {
            if (isLedgeGrabing)
            {
                isLedgeGrabing = false;
                justLedgeGrabbed = true;
                rb.isKinematic = false;
                rb.velocity = new Vector3(0, playerData.ledgeJumpSpeed);
                StartCoroutine(LedgeGrabCooldown());
                return;
            }

            if (canWallJump)
            {
                if (!hasWallJumped)
                {
                    Ray ray = new Ray(wallCheck.position, wallCheck.forward);

                    if (Physics.Raycast(ray, playerData.groundCheckLength, groundLayer))
                    {
                        hasWallJumped = true;
                        isWallJumping = true;
                        
                        if (facingRight)
                        {
                            
                            rb.velocity = new Vector3(-playerData.wallJumpSpeed * playerData.wallJumpHorizontalSpeedMultiplier, playerData.wallJumpSpeed, 0);
                        }
                        else
                        {
                            
                            rb.velocity = new Vector3(playerData.wallJumpSpeed * playerData.wallJumpHorizontalSpeedMultiplier, playerData.wallJumpSpeed, 0);
                        }
                        Turn();
                        audioManager.PlayJump();
                        StartCoroutine(WallJumpCooldown());
                        return;
                    }
                }
            }


            if (canDoubleJump)
            {
                if (!hasDoubleJumped)
                {
                    hasDoubleJumped = true;


                                       
                    rb.velocity = Utils.ChangeVector3Value(rb.velocity, Utils.Position.y, playerData.doubleJumpSpeed);
                    audioManager.PlayJump();

                    return;
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
            
        }

        if (value)
        {
            rb.AddForce(transform.up * playerData.jumpForce, ForceMode.VelocityChange);
            onGround = false;
            justJumped = true;
            audioManager.PlayJump();
            StartCoroutine(GroundCheckTimer());
        }
        
    }

    

    IEnumerator GroundCheckTimer()
    {
        float timer =0f;
        while (timer < playerData.groundCheckTimer)
        {
            timer += Time.deltaTime;
            yield return null;
        }

        justJumped = false;
        yield return null;
    }

    IEnumerator LedgeGrabCooldown()
    {
        yield return new WaitForSeconds(playerData.ledgeGrabCooldown);
        justLedgeGrabbed = false;
    }
    void DoubleJumpPowerUp()
    {
        OnPowerUP();
        canDoubleJump = true;
        
    }

    void DashPowerUp()
    {
        OnPowerUP();
        canDash = true;
    }

    void WallJumpPowerUp()
    {
        OnPowerUP();
        canWallJump = true;
    }

    void Dash(bool rightSide)
    {
        if (!canDash)
        {
            return;
        }

        if (hasDashed)
        {
            return;
        }

        hasDashed = true;
        isDashing = true;
        rb.useGravity = false;
        

        if (rightSide)
        {
            rb.velocity = new Vector3(playerData.dashSpeed, 0f, 0f);
            if (movingLeft)
            {
                Turn();
            }


        }
        else
        {
            rb.velocity = new Vector3(-playerData.dashSpeed, 0f, 0f);
            if (movingRight)
            {
                Turn();
            }
        }


        audioManager.PlayDash();

        StartCoroutine(DashEnder(rightSide));
        StartCoroutine(DashCooldown());


    }

    IEnumerator DashEnder(bool rightSide)
    {
        yield return new WaitForSeconds(playerData.dashDuration);
        rb.useGravity = true;
        isDashing = false;
    }

    IEnumerator DashCooldown()
    {
        yield return new WaitForSeconds(playerData.dashCooldown);

        hasDashed = false;

    }

    IEnumerator WallJumpCooldown()
    {
        yield return new WaitForSeconds(playerData.wallJumpDuration);
        isWallJumping = false;
        hasWallJumped = false;
    }


    void LedgeGrabPowerup()
    {
        OnPowerUP();
        canLedgeGrab = true;
    }

    void Fly(bool value)
    {
        if (!canFly)
        {
            return;

        }

        rb.useGravity = false;

        if (value)
        {
            rb.velocity = Utils.ChangeVector3Value(rb.velocity, Utils.Position.y, playerData.maxSpeed);
        }
        else
        {
            rb.velocity = Utils.ChangeVector3Value(rb.velocity, Utils.Position.y, -playerData.maxSpeed);
        }

    }

    void FlyStop()
    {
        if (!canFly)
        {
            return;
        }

        rb.velocity = Utils.ChangeVector3Value(rb.velocity, Utils.Position.y, 0);
    }

    void FlyPowerup()
    {
        OnPowerUP();
        canFly = true;
    }

    void OnPowerUP()
    {
        canMove = true;
        audioManager.PlayPowerup();
    }


    void AnimatorUpdate()
    {
        animator.SetBool("isHanging", isLedgeGrabing);
        animator.SetBool("isDashing", isDashing);
        animator.SetBool("isMoving", movingLeft || movingRight);
        if(!onGround)
        {
            if(rb.velocity.y > 0.1f)
            {
                animator.SetBool("isJumping", true);
            }
            else if(rb.velocity.y < -0.1f)
            {
                animator.SetBool("isFalling", true);
            }
        }
        else
        {
            animator.SetBool("isJumping", false);
            animator.SetBool("isFalling", false);
        }
    }
    
    void OnDeath()
    {
        audioManager.PlayDeath();
    }
}
