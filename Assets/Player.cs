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

    public List<Transform> groundChecks;
    public LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {

        inputManager.Spacebar += Jump;
        inputManager.Right += MoveRight;
        inputManager.Left += MoveLeft;

    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (!justJumped)
        {
            GroundCheck();
        }
        
    }

    public void Move()
    {
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
            rb.velocity = Utils.ChangeVector3Value(rb.velocity, Utils.Position.x, 0f);
        }


    }

    public void Turn()
    {
        transform.Rotate(transform.up, 180f);
    }

    public void MoveRight(bool value)
    {
        movingRight = value;

        if (value)
        {
            if (!facingRight)
            {
                Turn();
                facingRight = true;
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
                facingRight = false;
            }
        }


    }


    void GroundCheck()
    {
        foreach(Transform groundCheck in groundChecks)
        {
            RaycastHit hitInfo;

            Ray ray = new Ray(groundCheck.position, groundCheck.forward);

            Debug.DrawLine(groundCheck.position, groundCheck.position+groundCheck.forward * playerData.groundCheckLength, Color.red) ;

            if(Physics.Raycast(ray, out hitInfo, playerData.groundCheckLength, groundLayer))
            {                
                onGround = true;
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
        if (!onGround)
        {
            return;
        }

        if (value)
        {
            rb.AddForce(transform.up * playerData.jumpForce, ForceMode.VelocityChange);
            onGround = false;
            justJumped = true;
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

}
