using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoverData : ScriptableObject
{
    public float goSpeed;
    public float returnSpeed;
    public float onInitialTime;
    public float onEndTime;

    public float distanceThreshold;

    public bool startsActive;

    public VoidEventChannel initiationEvent;
    public VoidEventChannel endingEvent;
    public delegate void StartDelegate();
    public StartDelegate startEvent;
    public StartDelegate endEvent;
    

    public void OnEnable()
    {
        if (!startsActive)
        {
            initiationEvent.VoidEvent += Initiate;
            endingEvent.VoidEvent += OnEnd;

        }
    }

    public void OnDisable()
    {
        if (!startsActive)
        {
            initiationEvent.VoidEvent -= Initiate;
            endingEvent.VoidEvent -= OnEnd;
        }
    }

    public void Initiate()
    {
        startEvent?.Invoke();
    }

    public void OnEnd()
    {
        endEvent?.Invoke();
    }

}
