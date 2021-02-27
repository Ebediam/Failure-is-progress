// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""94218e99-e5bd-470f-9b04-46b56b6ddbe5"",
            ""actions"": [
                {
                    ""name"": ""LClick"",
                    ""type"": ""Button"",
                    ""id"": ""24a4b1d9-0bd1-4512-97f2-ea572dc9f61a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ESC"",
                    ""type"": ""Button"",
                    ""id"": ""40816f11-39a3-41f5-852b-80e1b6f6eac2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spacebar"",
                    ""type"": ""Button"",
                    ""id"": ""744bd24b-6216-40cb-a302-0cd5987f9e75"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""1c637d40-2bfa-4bc1-8b26-795c83e1158e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""0f3a5a70-e9ba-4173-964a-5ce6590d3711"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LDash"",
                    ""type"": ""Button"",
                    ""id"": ""391e0af4-686c-4f47-96e6-68e0600d2f18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RDash"",
                    ""type"": ""Button"",
                    ""id"": ""e9418f77-bee2-48fc-be81-2b5e38b039c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UpDown"",
                    ""type"": ""Button"",
                    ""id"": ""360db218-880f-47fa-96dc-68ee50882a25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fdce0165-b4d1-482b-bee1-f6e04f37a742"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e13aab3-2d7a-4fa4-a897-f28beb921d99"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ESC"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49f7077c-ec5a-4af5-92ff-45519343af12"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ESC"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c034245-d6f1-42db-9c9e-46796bc15816"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spacebar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d89bf235-d811-4a84-ad1f-297a2ec66168"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e1e3aca-d609-4d41-a700-d593a31e4222"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5769af52-7415-4dab-9386-8245b5bb1b6a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LDash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3fbe62f-a9ec-431b-ba2e-3a4c150e9cd0"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RDash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""0e9ececb-e0e8-492d-afe3-3c8bbd055659"",
                    ""path"": ""1DAxis(whichSideWins=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bee94528-c3c0-40ed-82be-9dc96d5a47f6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e7be2add-e0aa-4a97-91ad-89aee225c20d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_LClick = m_Player.FindAction("LClick", throwIfNotFound: true);
        m_Player_ESC = m_Player.FindAction("ESC", throwIfNotFound: true);
        m_Player_Spacebar = m_Player.FindAction("Spacebar", throwIfNotFound: true);
        m_Player_Right = m_Player.FindAction("Right", throwIfNotFound: true);
        m_Player_Left = m_Player.FindAction("Left", throwIfNotFound: true);
        m_Player_LDash = m_Player.FindAction("LDash", throwIfNotFound: true);
        m_Player_RDash = m_Player.FindAction("RDash", throwIfNotFound: true);
        m_Player_UpDown = m_Player.FindAction("UpDown", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_LClick;
    private readonly InputAction m_Player_ESC;
    private readonly InputAction m_Player_Spacebar;
    private readonly InputAction m_Player_Right;
    private readonly InputAction m_Player_Left;
    private readonly InputAction m_Player_LDash;
    private readonly InputAction m_Player_RDash;
    private readonly InputAction m_Player_UpDown;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LClick => m_Wrapper.m_Player_LClick;
        public InputAction @ESC => m_Wrapper.m_Player_ESC;
        public InputAction @Spacebar => m_Wrapper.m_Player_Spacebar;
        public InputAction @Right => m_Wrapper.m_Player_Right;
        public InputAction @Left => m_Wrapper.m_Player_Left;
        public InputAction @LDash => m_Wrapper.m_Player_LDash;
        public InputAction @RDash => m_Wrapper.m_Player_RDash;
        public InputAction @UpDown => m_Wrapper.m_Player_UpDown;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @LClick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLClick;
                @LClick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLClick;
                @LClick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLClick;
                @ESC.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnESC;
                @ESC.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnESC;
                @ESC.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnESC;
                @Spacebar.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpacebar;
                @Spacebar.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpacebar;
                @Spacebar.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpacebar;
                @Right.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRight;
                @Left.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeft;
                @LDash.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLDash;
                @LDash.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLDash;
                @LDash.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLDash;
                @RDash.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRDash;
                @RDash.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRDash;
                @RDash.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRDash;
                @UpDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpDown;
                @UpDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpDown;
                @UpDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpDown;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LClick.started += instance.OnLClick;
                @LClick.performed += instance.OnLClick;
                @LClick.canceled += instance.OnLClick;
                @ESC.started += instance.OnESC;
                @ESC.performed += instance.OnESC;
                @ESC.canceled += instance.OnESC;
                @Spacebar.started += instance.OnSpacebar;
                @Spacebar.performed += instance.OnSpacebar;
                @Spacebar.canceled += instance.OnSpacebar;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @LDash.started += instance.OnLDash;
                @LDash.performed += instance.OnLDash;
                @LDash.canceled += instance.OnLDash;
                @RDash.started += instance.OnRDash;
                @RDash.performed += instance.OnRDash;
                @RDash.canceled += instance.OnRDash;
                @UpDown.started += instance.OnUpDown;
                @UpDown.performed += instance.OnUpDown;
                @UpDown.canceled += instance.OnUpDown;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnLClick(InputAction.CallbackContext context);
        void OnESC(InputAction.CallbackContext context);
        void OnSpacebar(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnLDash(InputAction.CallbackContext context);
        void OnRDash(InputAction.CallbackContext context);
        void OnUpDown(InputAction.CallbackContext context);
    }
}
