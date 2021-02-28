using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{

    public VoidEventChannel activatorEvent;
    public VoidEventChannel deactivatorEvent;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        activatorEvent.VoidEvent += OnActivatorEvent;
        deactivatorEvent.VoidEvent += OnDeactivatorEvent;
    }


    void OnActivatorEvent()
    {
        gameObject.SetActive(true);
    }

    void OnDeactivatorEvent()
    {
        gameObject.SetActive(false);
    }

}
