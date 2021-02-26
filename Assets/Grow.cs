using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{

    public VoidEventChannel growEvent;
    public BoolEventChannel growTrueEvent;

    private void OnEnable()
    {
        growEvent.VoidEvent += OnGrowEvent;
        growTrueEvent.BoolEvent += OnGrow2Event;

    }

    private void OnDisable()
    {
        growEvent.VoidEvent -= OnGrowEvent;
        growTrueEvent.BoolEvent -= OnGrow2Event;
    }

    public void OnGrowEvent()
    {
        transform.position += Vector3.one;
    }

    public void OnGrow2Event(bool value)
    {

        if (value)
        {
            transform.localScale *= 2f;
        }
        else
        {
            transform.localScale /= 2f;
        }
        
    }

}
