using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Events/Power Event")]
public class PowerEventChannel : ScriptableObject
{
    public delegate void PowerDelegate(Powerup power);
    public PowerDelegate PowerEvent;


    public void Raise(Powerup power)
    {
        PowerEvent?.Invoke(power);
    }
}
