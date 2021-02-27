using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    public float acceleration;
    public float maxSpeed;
    public float jumpForce;
    public float speedDampening;

    public float groundCheckLength;
    public float groundCheckTimer;

    [Header("Double Jump settings")]
    public float doubleJumpSpeed;

    [Header("Dash settings")]
    public float dashSpeed;
    public float dashDuration;
    public float dashCooldown;

    [Header("Wall Jump settings")]
    public float wallJumpSpeed;
    public float wallJumpHorizontalSpeedMultiplier;
    public float wallJumpDuration;
}
