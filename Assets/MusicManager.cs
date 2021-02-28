using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource intro;
    public AudioSource loop;
    public AudioSource demonIntro;
    public AudioSource demonLoop;

    public VoidEventChannel deathEvent;
    public VoidEventChannel powerupEvent;

    public bool onMenu = false;



    private void Start()
    {
        deathEvent.VoidEvent += OnDeath;
        powerupEvent.VoidEvent += OnPowerup;
    }
    private void Update()
    {
        if (onMenu)
        {
            if(!demonIntro.isPlaying && !demonLoop.isPlaying)
            {
                demonLoop.Play();
            }
        }
        else
        {
            if (!intro.isPlaying && !loop.isPlaying)
            {
                loop.Play();
            }
        }


    }

    void OnDeath()
    {
        onMenu = true;
        loop.Stop();
        demonIntro.Play();
    }

    void OnPowerup()
    {
        onMenu = false;
        demonIntro.Stop();
        demonLoop.Stop();
        intro.Play();
    }


}
