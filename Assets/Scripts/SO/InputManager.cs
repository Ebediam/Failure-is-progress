using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
[CreateAssetMenu]
public class InputManager : ScriptableObject
{
    Controls controls;
    private void OnEnable()
    {
        Debug.Log("InputManager enabled");

        controls = new Controls();

        controls.Enable();

        controls.Player.LClick.performed += OnClick;
        controls.Player.Movement.performed += OnWASD;
    }


    private void OnDisable()
    {
        Debug.Log("InputManager disabled");

        controls.Player.LClick.performed -= OnClick;

    }

    void OnClick(InputAction.CallbackContext ctxt)
    {
        Debug.Log("Left click pressed");
    }


    void OnWASD(InputAction.CallbackContext ctxt)
    {
        Vector2 value = ctxt.ReadValue<Vector2>();
        Debug.Log(value);
    }


}


