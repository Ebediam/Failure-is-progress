using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlyActiveOnce : MonoBehaviour
{

    public VoidEventChannel DeathEvent;
    // Start is called before the first frame update
    void Start()
    {
        DeathEvent.VoidEvent += OnDeath;
    }


    void OnDeath()
    {
        gameObject.SetActive(false);
    }

}
