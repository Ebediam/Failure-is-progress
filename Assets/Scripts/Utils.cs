using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils 
{
    public enum Position
    {
        x,
        y,
        z
    }

    public static Vector3 ChangeVector3Value(Vector3 originalVector, Position position, float newValue)
    {
        Vector3 newVector;

        switch (position)
        {
            case Position.x:
                newVector = new Vector3(newValue, originalVector.y, originalVector.z);
                break;

            case Position.y:
                newVector = new Vector3(originalVector.x, newValue, originalVector.z);
                break;

            case Position.z:
                newVector = new Vector3(originalVector.x, originalVector.y, newValue);
                break;

            default:
                newVector = Vector3.zero;
                break;
        }

        return newVector;
    }


}
