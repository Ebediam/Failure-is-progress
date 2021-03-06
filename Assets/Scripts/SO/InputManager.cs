using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
[CreateAssetMenu]
public class InputManager : ScriptableObject
{
    Controls controls;

    public delegate void VoidEvent();
    public delegate void BoolEvent(bool value);
    public delegate void Vector2Event(Vector2 vector);
    


    public VoidEvent LeftClick;
    public VoidEvent ESC;
    public BoolEvent Spacebar;
    public BoolEvent Left;
    public BoolEvent Right;
    public BoolEvent Dash;
    public BoolEvent UpDown;
    public VoidEvent UpDownEnd;


    public Vector2Event WASD;
    

    private void OnEnable()
    {
        Debug.Log("InputManager enabled");

        controls = new Controls();
        controls.Enable();
        controls.Player.LClick.performed += OnClick;

        controls.Player.ESC.performed += OnEsc;
        controls.Player.Spacebar.performed += OnSpaceBar;


        controls.Player.Right.performed += OnRight;
        controls.Player.Right.canceled += OnRightEnd;

        controls.Player.Left.performed += OnLeft;
        controls.Player.Left.canceled += OnLeftEnd;

        controls.Player.LDash.performed += OnLDash;
        controls.Player.RDash.performed += OnRDash;

        controls.Player.UpDown.performed += OnUpDown;
        controls.Player.UpDown.canceled += OnUpDownEnd;
    }


    private void OnDisable()
    {
        Debug.Log("InputManager disabled");

        controls.Player.LClick.performed -= OnClick;
        controls.Player.ESC.performed -= OnEsc;
        controls.Player.Spacebar.performed -= OnSpaceBar;

    }

    void OnRight(InputAction.CallbackContext ctxt)
    {
        Right?.Invoke(true);
    }

    void OnRightEnd(InputAction.CallbackContext ctxt)
    {
        Right?.Invoke(false);
    }
    void OnLeft(InputAction.CallbackContext ctxt)
    {
        Left?.Invoke(true);
    }

    void OnLeftEnd(InputAction.CallbackContext ctxt)
    {
        Left?.Invoke(false);
    }


    void OnClick(InputAction.CallbackContext ctxt)
    {
        Debug.Log("Left click pressed");
        LeftClick?.Invoke();
    }


    void OnEsc(InputAction.CallbackContext ctxt)
    {
        Debug.Log("PAUSE");
        ESC?.Invoke();
    }

    void OnSpaceBar(InputAction.CallbackContext ctxt)
    {
        Spacebar?.Invoke(true);
    }

    void OnLDash(InputAction.CallbackContext ctxt)
    {
        Dash?.Invoke(false);
    }

    void OnRDash(InputAction.CallbackContext ctxt)
    {
        Dash?.Invoke(true);
    }

    void OnUpDown(InputAction.CallbackContext ctxt)
    {
        float value = ctxt.ReadValue<float>();

        if(value > 0)
        {
            UpDown?.Invoke(true);
        }
        else
        {
            UpDown?.Invoke(false);
        }
    }

    void OnUpDownEnd(InputAction.CallbackContext ctxt)
    {
        UpDownEnd?.Invoke();
    }
}


