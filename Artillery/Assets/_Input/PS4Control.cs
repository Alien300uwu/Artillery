// GENERATED AUTOMATICALLY FROM 'Assets/_Input/PS4Control.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PS4Control : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PS4Control()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PS4Control"",
    ""maps"": [
        {
            ""name"": ""Ps4Control"",
            ""id"": ""a20a77b3-06b2-42cd-97aa-a6b7b6a2d5db"",
            ""actions"": [
                {
                    ""name"": ""Apuntado"",
                    ""type"": ""Button"",
                    ""id"": ""0cbe0cd6-510a-45a5-a4d9-5e42cdd2ee57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Disparo"",
                    ""type"": ""Button"",
                    ""id"": ""8ae40007-af09-4849-87e5-d8d2eca74a85"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fuerza"",
                    ""type"": ""Button"",
                    ""id"": ""63de6c00-e2d3-451f-9078-48af407a7afa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d0098f6b-d2c4-48da-a26d-af8d62c5ca6d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Apuntado"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0a72c379-51ad-4910-a5c7-ec52e3f45e96"",
                    ""path"": ""<DualShockGamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Controller"",
                    ""action"": ""Apuntado"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d4775ed6-846e-48f0-9084-fe22ade43103"",
                    ""path"": ""<DualShockGamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Controller"",
                    ""action"": ""Apuntado"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""68aa64a1-d72b-4dd8-9b71-0481eac81824"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Controller"",
                    ""action"": ""Disparo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""5f8e3122-5138-4fed-9f8e-18c6f1f93bb0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fuerza"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""28d79b56-7c0c-4280-9bf7-9d99dea00c28"",
                    ""path"": ""<DualShockGamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Controller"",
                    ""action"": ""Fuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9b7a4fff-92f6-451a-ae60-69439c767acd"",
                    ""path"": ""<DualShockGamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4Controller"",
                    ""action"": ""Fuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PS4Controller"",
            ""bindingGroup"": ""PS4Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Ps4Control
        m_Ps4Control = asset.FindActionMap("Ps4Control", throwIfNotFound: true);
        m_Ps4Control_Apuntado = m_Ps4Control.FindAction("Apuntado", throwIfNotFound: true);
        m_Ps4Control_Disparo = m_Ps4Control.FindAction("Disparo", throwIfNotFound: true);
        m_Ps4Control_Fuerza = m_Ps4Control.FindAction("Fuerza", throwIfNotFound: true);
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

    // Ps4Control
    private readonly InputActionMap m_Ps4Control;
    private IPs4ControlActions m_Ps4ControlActionsCallbackInterface;
    private readonly InputAction m_Ps4Control_Apuntado;
    private readonly InputAction m_Ps4Control_Disparo;
    private readonly InputAction m_Ps4Control_Fuerza;
    public struct Ps4ControlActions
    {
        private @PS4Control m_Wrapper;
        public Ps4ControlActions(@PS4Control wrapper) { m_Wrapper = wrapper; }
        public InputAction @Apuntado => m_Wrapper.m_Ps4Control_Apuntado;
        public InputAction @Disparo => m_Wrapper.m_Ps4Control_Disparo;
        public InputAction @Fuerza => m_Wrapper.m_Ps4Control_Fuerza;
        public InputActionMap Get() { return m_Wrapper.m_Ps4Control; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Ps4ControlActions set) { return set.Get(); }
        public void SetCallbacks(IPs4ControlActions instance)
        {
            if (m_Wrapper.m_Ps4ControlActionsCallbackInterface != null)
            {
                @Apuntado.started -= m_Wrapper.m_Ps4ControlActionsCallbackInterface.OnApuntado;
                @Apuntado.performed -= m_Wrapper.m_Ps4ControlActionsCallbackInterface.OnApuntado;
                @Apuntado.canceled -= m_Wrapper.m_Ps4ControlActionsCallbackInterface.OnApuntado;
                @Disparo.started -= m_Wrapper.m_Ps4ControlActionsCallbackInterface.OnDisparo;
                @Disparo.performed -= m_Wrapper.m_Ps4ControlActionsCallbackInterface.OnDisparo;
                @Disparo.canceled -= m_Wrapper.m_Ps4ControlActionsCallbackInterface.OnDisparo;
                @Fuerza.started -= m_Wrapper.m_Ps4ControlActionsCallbackInterface.OnFuerza;
                @Fuerza.performed -= m_Wrapper.m_Ps4ControlActionsCallbackInterface.OnFuerza;
                @Fuerza.canceled -= m_Wrapper.m_Ps4ControlActionsCallbackInterface.OnFuerza;
            }
            m_Wrapper.m_Ps4ControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Apuntado.started += instance.OnApuntado;
                @Apuntado.performed += instance.OnApuntado;
                @Apuntado.canceled += instance.OnApuntado;
                @Disparo.started += instance.OnDisparo;
                @Disparo.performed += instance.OnDisparo;
                @Disparo.canceled += instance.OnDisparo;
                @Fuerza.started += instance.OnFuerza;
                @Fuerza.performed += instance.OnFuerza;
                @Fuerza.canceled += instance.OnFuerza;
            }
        }
    }
    public Ps4ControlActions @Ps4Control => new Ps4ControlActions(this);
    private int m_PS4ControllerSchemeIndex = -1;
    public InputControlScheme PS4ControllerScheme
    {
        get
        {
            if (m_PS4ControllerSchemeIndex == -1) m_PS4ControllerSchemeIndex = asset.FindControlSchemeIndex("PS4Controller");
            return asset.controlSchemes[m_PS4ControllerSchemeIndex];
        }
    }
    public interface IPs4ControlActions
    {
        void OnApuntado(InputAction.CallbackContext context);
        void OnDisparo(InputAction.CallbackContext context);
        void OnFuerza(InputAction.CallbackContext context);
    }
}
