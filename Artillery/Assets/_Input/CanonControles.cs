// GENERATED AUTOMATICALLY FROM 'Assets/_Input/CanonControles.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CanonControles : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CanonControles()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CanonControles"",
    ""maps"": [
        {
            ""name"": ""Canon"",
            ""id"": ""508ead6d-65e5-462e-990d-9da8739d0f8c"",
            ""actions"": [
                {
                    ""name"": ""Apuntar"",
                    ""type"": ""Button"",
                    ""id"": ""8622d042-2f8d-4b20-90be-7d3297a1247a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Disparar"",
                    ""type"": ""Button"",
                    ""id"": ""f9eebbb9-213d-4ae1-a413-8baa4a6faaa0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ModificarFuerza"",
                    ""type"": ""Button"",
                    ""id"": ""171e7b89-2929-4147-9b4c-e0d8517157da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""a4a221d2-edce-4251-b5d1-1a361b5ca3b7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f5c0f783-8edd-4b13-9b33-cfbe612a6f75"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generico"",
                    ""action"": ""Disparar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55c2036d-ddee-4c78-a850-f4c2f7584574"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generico"",
                    ""action"": ""Disparar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Teclado"",
                    ""id"": ""1828e145-8255-496f-8ab5-f8ee3d028a44"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Apuntar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""89af66c3-7aea-4995-b0f8-cf85484db411"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generico"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8e39464d-b0f6-4635-a45b-8e7e1613ea87"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generico"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Control"",
                    ""id"": ""4cd524c2-8c02-4217-aba3-7ba09c4adabb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generico"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cfd3a2ee-f30f-4cda-adff-bb226d95d1e0"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generico"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""519f25d2-bb6d-4252-97a0-cb9836815912"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generico"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Control"",
                    ""id"": ""30df1c2a-d91d-43bc-88f2-ba78da9d776a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bc0dfff1-241f-44b9-b8cb-3dcccdaa3cdc"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generico"",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""898cb621-1b19-4012-97fc-a5bbf72c4013"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generico"",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Teclado"",
                    ""id"": ""a44185e6-21b7-4988-9ffb-a6b2baf39db8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generico"",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""57d5c038-8329-44e8-9f9a-55f49f05679e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generico"",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b00626c9-c6a1-41c6-8ede-ec6ef76e349d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generico"",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""wasd"",
                    ""id"": ""29d52f12-5e8b-4f4f-9141-8b05aa3eadb1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5826d0bc-88bc-496b-98bf-f8cfeaad60a4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generico"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""76ec40d1-8090-4f34-bf25-b2c1d6c5b020"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generico"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c00e642e-0950-4e3d-9370-4cc73e04a7f0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generico"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ec66d74d-80be-4548-96af-4a69f4e13c29"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generico"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Generico"",
            ""bindingGroup"": ""Generico"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Canon
        m_Canon = asset.FindActionMap("Canon", throwIfNotFound: true);
        m_Canon_Apuntar = m_Canon.FindAction("Apuntar", throwIfNotFound: true);
        m_Canon_Disparar = m_Canon.FindAction("Disparar", throwIfNotFound: true);
        m_Canon_ModificarFuerza = m_Canon.FindAction("ModificarFuerza", throwIfNotFound: true);
        m_Canon_Move = m_Canon.FindAction("Move", throwIfNotFound: true);
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

    // Canon
    private readonly InputActionMap m_Canon;
    private ICanonActions m_CanonActionsCallbackInterface;
    private readonly InputAction m_Canon_Apuntar;
    private readonly InputAction m_Canon_Disparar;
    private readonly InputAction m_Canon_ModificarFuerza;
    private readonly InputAction m_Canon_Move;
    public struct CanonActions
    {
        private @CanonControles m_Wrapper;
        public CanonActions(@CanonControles wrapper) { m_Wrapper = wrapper; }
        public InputAction @Apuntar => m_Wrapper.m_Canon_Apuntar;
        public InputAction @Disparar => m_Wrapper.m_Canon_Disparar;
        public InputAction @ModificarFuerza => m_Wrapper.m_Canon_ModificarFuerza;
        public InputAction @Move => m_Wrapper.m_Canon_Move;
        public InputActionMap Get() { return m_Wrapper.m_Canon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CanonActions set) { return set.Get(); }
        public void SetCallbacks(ICanonActions instance)
        {
            if (m_Wrapper.m_CanonActionsCallbackInterface != null)
            {
                @Apuntar.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnApuntar;
                @Apuntar.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnApuntar;
                @Apuntar.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnApuntar;
                @Disparar.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnDisparar;
                @Disparar.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnDisparar;
                @Disparar.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnDisparar;
                @ModificarFuerza.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnModificarFuerza;
                @ModificarFuerza.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnModificarFuerza;
                @ModificarFuerza.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnModificarFuerza;
                @Move.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_CanonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Apuntar.started += instance.OnApuntar;
                @Apuntar.performed += instance.OnApuntar;
                @Apuntar.canceled += instance.OnApuntar;
                @Disparar.started += instance.OnDisparar;
                @Disparar.performed += instance.OnDisparar;
                @Disparar.canceled += instance.OnDisparar;
                @ModificarFuerza.started += instance.OnModificarFuerza;
                @ModificarFuerza.performed += instance.OnModificarFuerza;
                @ModificarFuerza.canceled += instance.OnModificarFuerza;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public CanonActions @Canon => new CanonActions(this);
    private int m_GenericoSchemeIndex = -1;
    public InputControlScheme GenericoScheme
    {
        get
        {
            if (m_GenericoSchemeIndex == -1) m_GenericoSchemeIndex = asset.FindControlSchemeIndex("Generico");
            return asset.controlSchemes[m_GenericoSchemeIndex];
        }
    }
    public interface ICanonActions
    {
        void OnApuntar(InputAction.CallbackContext context);
        void OnDisparar(InputAction.CallbackContext context);
        void OnModificarFuerza(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
