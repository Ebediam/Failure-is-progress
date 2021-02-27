using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PowerUp")]
public class Powerup : ScriptableObject
{
    public string powerName;
    public VoidEventChannel powerupEvent;

}
