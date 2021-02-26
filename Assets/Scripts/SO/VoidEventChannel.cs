using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Events/Void Event")]
public class VoidEventChannel : ScriptableObject
{

    public delegate void VoidEventDelegate();
    public VoidEventDelegate VoidEvent;



    public void Raise()
    {
        VoidEvent?.Invoke();
    }


}
