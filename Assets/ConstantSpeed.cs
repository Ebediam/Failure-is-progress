using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantSpeed : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddRelativeForce(new Vector3(0, 0, speed), ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
