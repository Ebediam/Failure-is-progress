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
    public delegate void StartDelegate();
    public StartDelegate startEvent;

    public void Initiate()
    {
        startEvent?.Invoke();
    }

}
