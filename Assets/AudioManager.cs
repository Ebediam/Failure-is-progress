using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public SoundData data;
    public AudioSource audioSource;

    public void PlayDash()
    {
        audioSource.Stop();
        audioSource.clip = data.dashSound;
        audioSource.Play();
    }

    public void PlayDeath()
    {
        audioSource.Stop();
        audioSource.clip = data.deathSound;
        audioSource.Play();
    }

    public void PlayGroundTouch()
    {
        audioSource.Stop();
        audioSource.clip = data.landingSound;
        audioSource.Play();
    }

    public void PlayJump()
    {
        audioSource.Stop();
        audioSource.clip = data.jumpSound;
        audioSource.Play();
    }

    public void PlayPowerup()
    {
        audioSource.Stop();
        audioSource.clip = data.powerupSound;
        audioSource.Play();
    }


}
