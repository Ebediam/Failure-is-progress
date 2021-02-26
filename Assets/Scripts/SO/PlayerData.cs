using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    public float acceleration;
    public float maxSpeed;
    public float jumpForce;

    public float groundCheckLength;
    public float groundCheckTimer;


}
