// GENERATED AUTOMATICALLY FROM 'Assets/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class Controls : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Cabin"",
            ""id"": ""d41683d9-74b0-4810-916e-edff696f55f0"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""eaa6c781-4d49-42a2-af9c-fe7a858f4a61"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""15293c62-54c7-4e55-b122-c69edb41a549"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""71e5caa1-06d3-4bf5-bc99-787815b14d79"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5fb049b3-cacc-4045-8709-5ce9828f4405"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""07b69674-9de7-4179-8717-d5493c35fec4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""31884c92-7932-4db6-b77a-a19c99c61f85"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""0e6f5a1d-7298-4605-8fff-ee83d678aad1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""02efdeef-32d3-42c2-be4a-695ebd7221fa"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""0a211b38-66e2-478a-bd27-f64d2340e711"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7a5662f1-2518-4908-9d95-b81dd164e783"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Pilot"",
            ""id"": ""afca3aad-fe43-4565-9591-5a71cd969f56"",
            ""actions"": [
                {
                    ""name"": ""Steer"",
                    ""type"": ""Value"",
                    ""id"": ""629ad16d-5a4c-4250-a9ef-ee9454f4a20a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""732c391f-7b84-4d43-8410-b1bd7a5c90e4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6221fa6d-a92e-4f82-b0aa-3cc4f4938d6d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ad38c1eb-8e02-4114-94ea-ff07faf709df"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""57d052e5-9705-4197-8e3b-1df21d57e750"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6f76b412-6665-4359-9c0c-3b213055897b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftRight"",
                    ""id"": ""c1e058af-2fc1-497a-82aa-3dcd26cfce0b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""35f698aa-409b-42aa-a5ff-dea47d78d5e1"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""918f5ca3-1651-4b28-a7ca-c640efcef617"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ddc288dc-ee4b-45e7-92e8-5890fe68bb65"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""abb2d4ff-3b1e-44cb-9ce8-5655ea849440"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Gunner"",
            ""id"": ""dea7e2f3-239e-4e56-989f-376ca33f1983"",
            ""actions"": [
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""b93eac11-e7ff-4573-9230-e6baccc7899c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Value"",
                    ""id"": ""f9f60c2b-58c5-4360-ad91-07360c5fc229"",
                    ""expectedControlType"": ""Integer"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b6948b81-09e8-4f7c-98c9-4faede0b247a"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""f6ca7f3f-e7f9-4ee6-bcd7-534f0914ccd7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3315e80a-980f-4604-b3ca-4a6fa868def2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""de46cd99-a6ca-4dd2-887c-99c4f0dd47a0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""565f8007-f5d3-4be1-98f8-7ca509fe3f05"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f4bc56c3-57e5-43bd-8748-8ca11c26522c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4920a119-a2ee-409b-a137-928648486070"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""973ca262-9a2b-48a5-8b39-3deee67f8269"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Combat"",
            ""id"": ""5c69dd36-6395-4776-b269-df2e17cc028b"",
            ""actions"": [
                {
                    ""name"": ""ModeSwitch"",
                    ""type"": ""Button"",
                    ""id"": ""4db2ef82-d641-426c-ba3e-77c3f1122849"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dc1c97ba-4c40-4fde-92aa-84e4199e200d"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ModeSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c4d0e8e-4094-4b98-bcca-21ad7df12334"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ModeSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Cabin
        m_Cabin = asset.FindActionMap("Cabin", throwIfNotFound: true);
        m_Cabin_Interact = m_Cabin.FindAction("Interact", throwIfNotFound: true);
        m_Cabin_Move = m_Cabin.FindAction("Move", throwIfNotFound: true);
        // Pilot
        m_Pilot = asset.FindActionMap("Pilot", throwIfNotFound: true);
        m_Pilot_Steer = m_Pilot.FindAction("Steer", throwIfNotFound: true);
        // Gunner
        m_Gunner = asset.FindActionMap("Gunner", throwIfNotFound: true);
        m_Gunner_Aim = m_Gunner.FindAction("Aim", throwIfNotFound: true);
        m_Gunner_Shoot = m_Gunner.FindAction("Shoot", throwIfNotFound: true);
        // Combat
        m_Combat = asset.FindActionMap("Combat", throwIfNotFound: true);
        m_Combat_ModeSwitch = m_Combat.FindAction("ModeSwitch", throwIfNotFound: true);
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

    // Cabin
    private readonly InputActionMap m_Cabin;
    private ICabinActions m_CabinActionsCallbackInterface;
    private readonly InputAction m_Cabin_Interact;
    private readonly InputAction m_Cabin_Move;
    public struct CabinActions
    {
        private Controls m_Wrapper;
        public CabinActions(Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Cabin_Interact;
        public InputAction @Move => m_Wrapper.m_Cabin_Move;
        public InputActionMap Get() { return m_Wrapper.m_Cabin; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CabinActions set) { return set.Get(); }
        public void SetCallbacks(ICabinActions instance)
        {
            if (m_Wrapper.m_CabinActionsCallbackInterface != null)
            {
                Interact.started -= m_Wrapper.m_CabinActionsCallbackInterface.OnInteract;
                Interact.performed -= m_Wrapper.m_CabinActionsCallbackInterface.OnInteract;
                Interact.canceled -= m_Wrapper.m_CabinActionsCallbackInterface.OnInteract;
                Move.started -= m_Wrapper.m_CabinActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_CabinActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_CabinActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_CabinActionsCallbackInterface = instance;
            if (instance != null)
            {
                Interact.started += instance.OnInteract;
                Interact.performed += instance.OnInteract;
                Interact.canceled += instance.OnInteract;
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
            }
        }
    }
    public CabinActions @Cabin => new CabinActions(this);

    // Pilot
    private readonly InputActionMap m_Pilot;
    private IPilotActions m_PilotActionsCallbackInterface;
    private readonly InputAction m_Pilot_Steer;
    public struct PilotActions
    {
        private Controls m_Wrapper;
        public PilotActions(Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Steer => m_Wrapper.m_Pilot_Steer;
        public InputActionMap Get() { return m_Wrapper.m_Pilot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PilotActions set) { return set.Get(); }
        public void SetCallbacks(IPilotActions instance)
        {
            if (m_Wrapper.m_PilotActionsCallbackInterface != null)
            {
                Steer.started -= m_Wrapper.m_PilotActionsCallbackInterface.OnSteer;
                Steer.performed -= m_Wrapper.m_PilotActionsCallbackInterface.OnSteer;
                Steer.canceled -= m_Wrapper.m_PilotActionsCallbackInterface.OnSteer;
            }
            m_Wrapper.m_PilotActionsCallbackInterface = instance;
            if (instance != null)
            {
                Steer.started += instance.OnSteer;
                Steer.performed += instance.OnSteer;
                Steer.canceled += instance.OnSteer;
            }
        }
    }
    public PilotActions @Pilot => new PilotActions(this);

    // Gunner
    private readonly InputActionMap m_Gunner;
    private IGunnerActions m_GunnerActionsCallbackInterface;
    private readonly InputAction m_Gunner_Aim;
    private readonly InputAction m_Gunner_Shoot;
    public struct GunnerActions
    {
        private Controls m_Wrapper;
        public GunnerActions(Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Aim => m_Wrapper.m_Gunner_Aim;
        public InputAction @Shoot => m_Wrapper.m_Gunner_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Gunner; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GunnerActions set) { return set.Get(); }
        public void SetCallbacks(IGunnerActions instance)
        {
            if (m_Wrapper.m_GunnerActionsCallbackInterface != null)
            {
                Aim.started -= m_Wrapper.m_GunnerActionsCallbackInterface.OnAim;
                Aim.performed -= m_Wrapper.m_GunnerActionsCallbackInterface.OnAim;
                Aim.canceled -= m_Wrapper.m_GunnerActionsCallbackInterface.OnAim;
                Shoot.started -= m_Wrapper.m_GunnerActionsCallbackInterface.OnShoot;
                Shoot.performed -= m_Wrapper.m_GunnerActionsCallbackInterface.OnShoot;
                Shoot.canceled -= m_Wrapper.m_GunnerActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_GunnerActionsCallbackInterface = instance;
            if (instance != null)
            {
                Aim.started += instance.OnAim;
                Aim.performed += instance.OnAim;
                Aim.canceled += instance.OnAim;
                Shoot.started += instance.OnShoot;
                Shoot.performed += instance.OnShoot;
                Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public GunnerActions @Gunner => new GunnerActions(this);

    // Combat
    private readonly InputActionMap m_Combat;
    private ICombatActions m_CombatActionsCallbackInterface;
    private readonly InputAction m_Combat_ModeSwitch;
    public struct CombatActions
    {
        private Controls m_Wrapper;
        public CombatActions(Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ModeSwitch => m_Wrapper.m_Combat_ModeSwitch;
        public InputActionMap Get() { return m_Wrapper.m_Combat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CombatActions set) { return set.Get(); }
        public void SetCallbacks(ICombatActions instance)
        {
            if (m_Wrapper.m_CombatActionsCallbackInterface != null)
            {
                ModeSwitch.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnModeSwitch;
                ModeSwitch.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnModeSwitch;
                ModeSwitch.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnModeSwitch;
            }
            m_Wrapper.m_CombatActionsCallbackInterface = instance;
            if (instance != null)
            {
                ModeSwitch.started += instance.OnModeSwitch;
                ModeSwitch.performed += instance.OnModeSwitch;
                ModeSwitch.canceled += instance.OnModeSwitch;
            }
        }
    }
    public CombatActions @Combat => new CombatActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface ICabinActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IPilotActions
    {
        void OnSteer(InputAction.CallbackContext context);
    }
    public interface IGunnerActions
    {
        void OnAim(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
    public interface ICombatActions
    {
        void OnModeSwitch(InputAction.CallbackContext context);
    }
}
