using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BoolEventChannel))]
public class BoolEventScriptEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if(GUILayout.Button("Raise True Event"))
        {
            BoolEventChannel myScript = target as BoolEventChannel;
            myScript.Raise(true);
        }


        if (GUILayout.Button("Raise False Event"))
        {
            BoolEventChannel myScript = target as BoolEventChannel;
            myScript.Raise(false);
        }



    }

}
