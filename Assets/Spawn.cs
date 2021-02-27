using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public VoidEventChannel deathEvent;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        deathEvent.VoidEvent += OnDeath;
    }


    void OnDeath()
    {
        player.transform.position = transform.position;
                
        player.rb.velocity = Vector3.zero;
        player.canMove = false;
    }

}
