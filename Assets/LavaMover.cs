using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaMover : MonoBehaviour
{

    public MeshRenderer renderer;
    public float horizontalMoveSpeed;
    public float verticalMoveSpeed;

    // Update is called once per frame
    void Update()
    {
        renderer.material.SetTextureOffset("_BaseMap", renderer.material.GetTextureOffset("_BaseMap")+new Vector2(horizontalMoveSpeed, verticalMoveSpeed)*Time.deltaTime);

        
    }
}
