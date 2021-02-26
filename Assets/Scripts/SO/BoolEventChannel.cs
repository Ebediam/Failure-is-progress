using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Events/Bool Event")]
public class BoolEventChannel : ScriptableObject
{
    public delegate void BoolEventDelegate(bool value);
    public BoolEventDelegate BoolEvent;

    public void Raise(bool value)
    {
        BoolEvent?.Invoke(value);
    }




}
