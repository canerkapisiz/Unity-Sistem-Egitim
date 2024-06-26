//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Ornek/InputAction/karakteraction_Gamepad.inputactions
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

public partial class @Karakteraction_Gamepad: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Karakteraction_Gamepad()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""karakteraction_Gamepad"",
    ""maps"": [
        {
            ""name"": ""Playercontrol"",
            ""id"": ""4317c911-ade8-47d2-9bed-f5d383d10034"",
            ""actions"": [
                {
                    ""name"": ""Hareket"",
                    ""type"": ""Value"",
                    ""id"": ""00cd481d-890a-466e-9b19-a7f144599076"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Ziplama"",
                    ""type"": ""Button"",
                    ""id"": ""7cd99932-ae2c-418b-a2a7-c45e87f3c6e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AtesEtme"",
                    ""type"": ""Button"",
                    ""id"": ""92c264be-0b19-4aa9-b992-7d240daf511c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Donus"",
                    ""type"": ""Value"",
                    ""id"": ""7551bdfa-6f0f-47eb-af16-7000826ff5b8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""45873fc1-2f7b-4782-91b0-c67e257dc087"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ziplama"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9de29b13-6f02-4369-825a-c9bdc6671154"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AtesEtme"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""donus"",
                    ""id"": ""664d2d08-a90e-45d5-997b-b012ac409b5c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Donus"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b9e27b16-91d2-41f9-b283-529ae7f2ba60"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Donus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""81de40e1-6b8c-46f8-a50b-aae566ffa887"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Donus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""04bfe474-c849-44d7-91c6-ad8aa426ceb6"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Donus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bb2b5770-59bc-4429-8624-09e2d280fecb"",
                    ""path"": ""<HID::Microntek              USB Joystick          >/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Donus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Hareket"",
                    ""id"": ""0dfda1a4-c861-4525-8fe5-24885a7df133"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hareket"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""62391fb6-2b22-4b07-b558-2af83bc65852"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hareket"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5b959b3d-5282-442f-b629-e9212ced8d3a"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hareket"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""700f7b64-ce05-44de-9870-6234956281ee"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hareket"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e9a72b6a-1409-41e3-9920-e7e2b1af482c"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hareket"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Playercontrol
        m_Playercontrol = asset.FindActionMap("Playercontrol", throwIfNotFound: true);
        m_Playercontrol_Hareket = m_Playercontrol.FindAction("Hareket", throwIfNotFound: true);
        m_Playercontrol_Ziplama = m_Playercontrol.FindAction("Ziplama", throwIfNotFound: true);
        m_Playercontrol_AtesEtme = m_Playercontrol.FindAction("AtesEtme", throwIfNotFound: true);
        m_Playercontrol_Donus = m_Playercontrol.FindAction("Donus", throwIfNotFound: true);
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

    // Playercontrol
    private readonly InputActionMap m_Playercontrol;
    private List<IPlayercontrolActions> m_PlayercontrolActionsCallbackInterfaces = new List<IPlayercontrolActions>();
    private readonly InputAction m_Playercontrol_Hareket;
    private readonly InputAction m_Playercontrol_Ziplama;
    private readonly InputAction m_Playercontrol_AtesEtme;
    private readonly InputAction m_Playercontrol_Donus;
    public struct PlayercontrolActions
    {
        private @Karakteraction_Gamepad m_Wrapper;
        public PlayercontrolActions(@Karakteraction_Gamepad wrapper) { m_Wrapper = wrapper; }
        public InputAction @Hareket => m_Wrapper.m_Playercontrol_Hareket;
        public InputAction @Ziplama => m_Wrapper.m_Playercontrol_Ziplama;
        public InputAction @AtesEtme => m_Wrapper.m_Playercontrol_AtesEtme;
        public InputAction @Donus => m_Wrapper.m_Playercontrol_Donus;
        public InputActionMap Get() { return m_Wrapper.m_Playercontrol; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayercontrolActions set) { return set.Get(); }
        public void AddCallbacks(IPlayercontrolActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayercontrolActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayercontrolActionsCallbackInterfaces.Add(instance);
            @Hareket.started += instance.OnHareket;
            @Hareket.performed += instance.OnHareket;
            @Hareket.canceled += instance.OnHareket;
            @Ziplama.started += instance.OnZiplama;
            @Ziplama.performed += instance.OnZiplama;
            @Ziplama.canceled += instance.OnZiplama;
            @AtesEtme.started += instance.OnAtesEtme;
            @AtesEtme.performed += instance.OnAtesEtme;
            @AtesEtme.canceled += instance.OnAtesEtme;
            @Donus.started += instance.OnDonus;
            @Donus.performed += instance.OnDonus;
            @Donus.canceled += instance.OnDonus;
        }

        private void UnregisterCallbacks(IPlayercontrolActions instance)
        {
            @Hareket.started -= instance.OnHareket;
            @Hareket.performed -= instance.OnHareket;
            @Hareket.canceled -= instance.OnHareket;
            @Ziplama.started -= instance.OnZiplama;
            @Ziplama.performed -= instance.OnZiplama;
            @Ziplama.canceled -= instance.OnZiplama;
            @AtesEtme.started -= instance.OnAtesEtme;
            @AtesEtme.performed -= instance.OnAtesEtme;
            @AtesEtme.canceled -= instance.OnAtesEtme;
            @Donus.started -= instance.OnDonus;
            @Donus.performed -= instance.OnDonus;
            @Donus.canceled -= instance.OnDonus;
        }

        public void RemoveCallbacks(IPlayercontrolActions instance)
        {
            if (m_Wrapper.m_PlayercontrolActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayercontrolActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayercontrolActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayercontrolActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayercontrolActions @Playercontrol => new PlayercontrolActions(this);
    public interface IPlayercontrolActions
    {
        void OnHareket(InputAction.CallbackContext context);
        void OnZiplama(InputAction.CallbackContext context);
        void OnAtesEtme(InputAction.CallbackContext context);
        void OnDonus(InputAction.CallbackContext context);
    }
}
