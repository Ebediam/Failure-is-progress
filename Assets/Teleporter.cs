using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public int fireballLayer;
    public Transform teleportPosition;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == fireballLayer)
        {
            other.transform.position = teleportPosition.position;
        }
    }

}
