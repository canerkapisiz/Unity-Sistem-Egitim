//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputAction/karakterAction1.inputactions
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

public partial class @KarakterAction1: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @KarakterAction1()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""karakterAction1"",
    ""maps"": [
        {
            ""name"": ""PlayerControl"",
            ""id"": ""94dd5044-6d93-4243-8cf9-8aa14ef437b1"",
            ""actions"": [
                {
                    ""name"": ""Hareket"",
                    ""type"": ""Value"",
                    ""id"": ""c266473c-6fb9-424f-8edd-0ac79db3a91e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Ziplama"",
                    ""type"": ""Button"",
                    ""id"": ""014ccaaa-f9f5-4dc3-9d43-74aacfc4541d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AtesEtme"",
                    ""type"": ""Button"",
                    ""id"": ""1cdac17d-d95d-48b3-9a26-f0d589355781"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Donus"",
                    ""type"": ""Value"",
                    ""id"": ""a8796cc9-f8af-4635-9e64-7f65dad64870"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Hareket"",
                    ""id"": ""a081739b-4acd-4181-8802-b8345bace196"",
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
                    ""id"": ""075dfc76-c3b2-454e-8caa-65f4931ec495"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hareket"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8232db60-0f3c-420f-bf6c-8860c00b13ca"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hareket"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9bb975a4-7afc-43f9-9d93-b9dfa7edff5f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hareket"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b3fe2946-27a7-4fb8-9921-6c6523d7b245"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hareket"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bda05ded-ece1-4b01-9ced-4d4b8d574413"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ziplama"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e7f8ac4-ccda-4d6c-a23c-0f9d7df317e0"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AtesEtme"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""donus"",
                    ""id"": ""92ab8fe9-54f6-4f6f-870f-689c10a38b66"",
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
                    ""id"": ""392374ec-78bc-4b6c-a67a-5ea233dc0467"",
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
                    ""id"": ""23ed9829-e157-4490-9c5e-c0ac4f00a10d"",
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
                    ""id"": ""5ba17cba-bfb4-4f07-805e-2e8306284366"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Donus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0599e1b3-123f-491f-9a07-3b9f0a2cfce3"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Donus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControl
        m_PlayerControl = asset.FindActionMap("PlayerControl", throwIfNotFound: true);
        m_PlayerControl_Hareket = m_PlayerControl.FindAction("Hareket", throwIfNotFound: true);
        m_PlayerControl_Ziplama = m_PlayerControl.FindAction("Ziplama", throwIfNotFound: true);
        m_PlayerControl_AtesEtme = m_PlayerControl.FindAction("AtesEtme", throwIfNotFound: true);
        m_PlayerControl_Donus = m_PlayerControl.FindAction("Donus", throwIfNotFound: true);
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

    // PlayerControl
    private readonly InputActionMap m_PlayerControl;
    private List<IPlayerControlActions> m_PlayerControlActionsCallbackInterfaces = new List<IPlayerControlActions>();
    private readonly InputAction m_PlayerControl_Hareket;
    private readonly InputAction m_PlayerControl_Ziplama;
    private readonly InputAction m_PlayerControl_AtesEtme;
    private readonly InputAction m_PlayerControl_Donus;
    public struct PlayerControlActions
    {
        private @KarakterAction1 m_Wrapper;
        public PlayerControlActions(@KarakterAction1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @Hareket => m_Wrapper.m_PlayerControl_Hareket;
        public InputAction @Ziplama => m_Wrapper.m_PlayerControl_Ziplama;
        public InputAction @AtesEtme => m_Wrapper.m_PlayerControl_AtesEtme;
        public InputAction @Donus => m_Wrapper.m_PlayerControl_Donus;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerControlActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerControlActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerControlActionsCallbackInterfaces.Add(instance);
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

        private void UnregisterCallbacks(IPlayerControlActions instance)
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

        public void RemoveCallbacks(IPlayerControlActions instance)
        {
            if (m_Wrapper.m_PlayerControlActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerControlActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerControlActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerControlActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerControlActions @PlayerControl => new PlayerControlActions(this);
    public interface IPlayerControlActions
    {
        void OnHareket(InputAction.CallbackContext context);
        void OnZiplama(InputAction.CallbackContext context);
        void OnAtesEtme(InputAction.CallbackContext context);
        void OnDonus(InputAction.CallbackContext context);
    }
}