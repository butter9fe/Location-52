//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Scripts/Input/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""MainGameplay"",
            ""id"": ""ff415300-6e35-470e-ac5e-fdd154664357"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""60c55361-f6ea-4909-a4f8-dee9ec3bc8b1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""9fcc70f4-4b2f-43d0-addc-3a038085cd47"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""1f0c5580-8507-409d-a31b-541bd5d81d36"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""d4a5fff0-5a9d-40c0-babe-b46ce7b23f64"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""4848f9dd-e555-488d-8336-f0ff73898338"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""a0f1a030-a456-462e-ac34-f0fcbed329f0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ADSItem"",
                    ""type"": ""Button"",
                    ""id"": ""3a8c36b3-8988-4e35-9d66-e8db73433c91"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""UseItem"",
                    ""type"": ""Button"",
                    ""id"": ""a71177c7-d693-40bd-a9e5-7a09a73ef6be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ViewAlbum"",
                    ""type"": ""Button"",
                    ""id"": ""4eb2d965-055d-4087-8001-b8a54c3301e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ScrollAlbum"",
                    ""type"": ""Value"",
                    ""id"": ""04b9fd74-119e-4767-b1c8-542104b96c6c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ToggleFlash"",
                    ""type"": ""Button"",
                    ""id"": ""32cea5e3-3349-4350-96ab-9add4c17154a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TEMPOpenInventory"",
                    ""type"": ""Button"",
                    ""id"": ""114fd448-c88f-4f81-b00e-51d99e59a93e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotateInventoryItem"",
                    ""type"": ""Button"",
                    ""id"": ""f30bd377-ac67-463a-8a72-0cfd35c225e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ea7e3318-3d34-4170-ac43-db9eda33409b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""89c15da3-a33c-42ed-b34c-f903e9b7f94a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c3cda605-00f1-4ec2-b325-4b3387a579ff"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f428eebd-d216-485b-a2f7-96f6e466f6a6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a419aa60-390e-44bd-a5b6-f6a8896495fe"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""091b0644-7012-40c0-aff8-9e88cc2a6986"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94f81812-b4bf-47ca-8f0a-73a206d36ed7"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05ab0ccd-186e-467b-8780-aa9877ee9a63"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1cffb06-fdb7-4687-ad2e-69a45e51c2d1"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d2bba56-abc2-4c09-b7bf-6adbaf99c308"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""150fef88-6b44-47a0-895d-7b3c01a4de38"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""ADSItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f667f4bf-a42c-45fd-9ac7-03329f464bf9"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""UseItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41d0bc3b-323a-458f-8ca0-312cdbb5de28"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""ViewAlbum"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec96fb86-d0c1-4568-ba03-174e3dbdd715"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""ScrollAlbum"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbc96422-da54-4b0d-ad3d-9fb8aeca3870"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""ToggleFlash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c10e669-3dbc-4285-a93b-4f31c9eb8b85"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""TEMPOpenInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c167c0bd-b7cc-4d3d-a956-1c82a97532e6"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""RotateInventoryItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MainGameplay
        m_MainGameplay = asset.FindActionMap("MainGameplay", throwIfNotFound: true);
        m_MainGameplay_Movement = m_MainGameplay.FindAction("Movement", throwIfNotFound: true);
        m_MainGameplay_Crouch = m_MainGameplay.FindAction("Crouch", throwIfNotFound: true);
        m_MainGameplay_Sprint = m_MainGameplay.FindAction("Sprint", throwIfNotFound: true);
        m_MainGameplay_Jump = m_MainGameplay.FindAction("Jump", throwIfNotFound: true);
        m_MainGameplay_Camera = m_MainGameplay.FindAction("Camera", throwIfNotFound: true);
        m_MainGameplay_Interact = m_MainGameplay.FindAction("Interact", throwIfNotFound: true);
        m_MainGameplay_ADSItem = m_MainGameplay.FindAction("ADSItem", throwIfNotFound: true);
        m_MainGameplay_UseItem = m_MainGameplay.FindAction("UseItem", throwIfNotFound: true);
        m_MainGameplay_ViewAlbum = m_MainGameplay.FindAction("ViewAlbum", throwIfNotFound: true);
        m_MainGameplay_ScrollAlbum = m_MainGameplay.FindAction("ScrollAlbum", throwIfNotFound: true);
        m_MainGameplay_ToggleFlash = m_MainGameplay.FindAction("ToggleFlash", throwIfNotFound: true);
        m_MainGameplay_TEMPOpenInventory = m_MainGameplay.FindAction("TEMPOpenInventory", throwIfNotFound: true);
        m_MainGameplay_RotateInventoryItem = m_MainGameplay.FindAction("RotateInventoryItem", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // MainGameplay
    private readonly InputActionMap m_MainGameplay;
    private List<IMainGameplayActions> m_MainGameplayActionsCallbackInterfaces = new List<IMainGameplayActions>();
    private readonly InputAction m_MainGameplay_Movement;
    private readonly InputAction m_MainGameplay_Crouch;
    private readonly InputAction m_MainGameplay_Sprint;
    private readonly InputAction m_MainGameplay_Jump;
    private readonly InputAction m_MainGameplay_Camera;
    private readonly InputAction m_MainGameplay_Interact;
    private readonly InputAction m_MainGameplay_ADSItem;
    private readonly InputAction m_MainGameplay_UseItem;
    private readonly InputAction m_MainGameplay_ViewAlbum;
    private readonly InputAction m_MainGameplay_ScrollAlbum;
    private readonly InputAction m_MainGameplay_ToggleFlash;
    private readonly InputAction m_MainGameplay_TEMPOpenInventory;
    private readonly InputAction m_MainGameplay_RotateInventoryItem;
    public struct MainGameplayActions
    {
        private @Controls m_Wrapper;
        public MainGameplayActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_MainGameplay_Movement;
        public InputAction @Crouch => m_Wrapper.m_MainGameplay_Crouch;
        public InputAction @Sprint => m_Wrapper.m_MainGameplay_Sprint;
        public InputAction @Jump => m_Wrapper.m_MainGameplay_Jump;
        public InputAction @Camera => m_Wrapper.m_MainGameplay_Camera;
        public InputAction @Interact => m_Wrapper.m_MainGameplay_Interact;
        public InputAction @ADSItem => m_Wrapper.m_MainGameplay_ADSItem;
        public InputAction @UseItem => m_Wrapper.m_MainGameplay_UseItem;
        public InputAction @ViewAlbum => m_Wrapper.m_MainGameplay_ViewAlbum;
        public InputAction @ScrollAlbum => m_Wrapper.m_MainGameplay_ScrollAlbum;
        public InputAction @ToggleFlash => m_Wrapper.m_MainGameplay_ToggleFlash;
        public InputAction @TEMPOpenInventory => m_Wrapper.m_MainGameplay_TEMPOpenInventory;
        public InputAction @RotateInventoryItem => m_Wrapper.m_MainGameplay_RotateInventoryItem;
        public InputActionMap Get() { return m_Wrapper.m_MainGameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainGameplayActions set) { return set.Get(); }
        public void AddCallbacks(IMainGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_MainGameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MainGameplayActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Crouch.started += instance.OnCrouch;
            @Crouch.performed += instance.OnCrouch;
            @Crouch.canceled += instance.OnCrouch;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Camera.started += instance.OnCamera;
            @Camera.performed += instance.OnCamera;
            @Camera.canceled += instance.OnCamera;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @ADSItem.started += instance.OnADSItem;
            @ADSItem.performed += instance.OnADSItem;
            @ADSItem.canceled += instance.OnADSItem;
            @UseItem.started += instance.OnUseItem;
            @UseItem.performed += instance.OnUseItem;
            @UseItem.canceled += instance.OnUseItem;
            @ViewAlbum.started += instance.OnViewAlbum;
            @ViewAlbum.performed += instance.OnViewAlbum;
            @ViewAlbum.canceled += instance.OnViewAlbum;
            @ScrollAlbum.started += instance.OnScrollAlbum;
            @ScrollAlbum.performed += instance.OnScrollAlbum;
            @ScrollAlbum.canceled += instance.OnScrollAlbum;
            @ToggleFlash.started += instance.OnToggleFlash;
            @ToggleFlash.performed += instance.OnToggleFlash;
            @ToggleFlash.canceled += instance.OnToggleFlash;
            @TEMPOpenInventory.started += instance.OnTEMPOpenInventory;
            @TEMPOpenInventory.performed += instance.OnTEMPOpenInventory;
            @TEMPOpenInventory.canceled += instance.OnTEMPOpenInventory;
            @RotateInventoryItem.started += instance.OnRotateInventoryItem;
            @RotateInventoryItem.performed += instance.OnRotateInventoryItem;
            @RotateInventoryItem.canceled += instance.OnRotateInventoryItem;
        }

        private void UnregisterCallbacks(IMainGameplayActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Crouch.started -= instance.OnCrouch;
            @Crouch.performed -= instance.OnCrouch;
            @Crouch.canceled -= instance.OnCrouch;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Camera.started -= instance.OnCamera;
            @Camera.performed -= instance.OnCamera;
            @Camera.canceled -= instance.OnCamera;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @ADSItem.started -= instance.OnADSItem;
            @ADSItem.performed -= instance.OnADSItem;
            @ADSItem.canceled -= instance.OnADSItem;
            @UseItem.started -= instance.OnUseItem;
            @UseItem.performed -= instance.OnUseItem;
            @UseItem.canceled -= instance.OnUseItem;
            @ViewAlbum.started -= instance.OnViewAlbum;
            @ViewAlbum.performed -= instance.OnViewAlbum;
            @ViewAlbum.canceled -= instance.OnViewAlbum;
            @ScrollAlbum.started -= instance.OnScrollAlbum;
            @ScrollAlbum.performed -= instance.OnScrollAlbum;
            @ScrollAlbum.canceled -= instance.OnScrollAlbum;
            @ToggleFlash.started -= instance.OnToggleFlash;
            @ToggleFlash.performed -= instance.OnToggleFlash;
            @ToggleFlash.canceled -= instance.OnToggleFlash;
            @TEMPOpenInventory.started -= instance.OnTEMPOpenInventory;
            @TEMPOpenInventory.performed -= instance.OnTEMPOpenInventory;
            @TEMPOpenInventory.canceled -= instance.OnTEMPOpenInventory;
            @RotateInventoryItem.started -= instance.OnRotateInventoryItem;
            @RotateInventoryItem.performed -= instance.OnRotateInventoryItem;
            @RotateInventoryItem.canceled -= instance.OnRotateInventoryItem;
        }

        public void RemoveCallbacks(IMainGameplayActions instance)
        {
            if (m_Wrapper.m_MainGameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMainGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_MainGameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MainGameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MainGameplayActions @MainGameplay => new MainGameplayActions(this);
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    public interface IMainGameplayActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnADSItem(InputAction.CallbackContext context);
        void OnUseItem(InputAction.CallbackContext context);
        void OnViewAlbum(InputAction.CallbackContext context);
        void OnScrollAlbum(InputAction.CallbackContext context);
        void OnToggleFlash(InputAction.CallbackContext context);
        void OnTEMPOpenInventory(InputAction.CallbackContext context);
        void OnRotateInventoryItem(InputAction.CallbackContext context);
    }
}
