// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/SimulationControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @SimulationControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @SimulationControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SimulationControls"",
    ""maps"": [
        {
            ""name"": ""CameraMovementAndRotation"",
            ""id"": ""6280b24b-b4b4-44b2-9617-f402bd6340c8"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""6aececa6-52fd-42eb-8fd2-a41419d8c15f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Button"",
                    ""id"": ""8de446ea-9b28-4321-9862-7925cfe7b44d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ResetPosition"",
                    ""type"": ""Button"",
                    ""id"": ""b0038a55-a3a5-4a68-9350-c8b36aabf392"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""d8283ab7-1e7b-4b2e-ad51-00b11fa2a86a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""b54f2845-897c-4565-8a00-d5bcebb3d6de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""adf26a9e-8388-4ce3-9325-c3eb4ffed6bd"",
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
                    ""id"": ""7261d918-10d2-440f-8822-8ff23e647e32"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9ba5bb25-94dc-4cdb-8b1c-54bea1191060"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f966cdf8-ed6b-4dd9-8a53-f94e4c778248"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2957590a-c014-411c-96ac-3032302b389e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""XYBA"",
                    ""id"": ""203cd909-51d7-4def-827c-65deb0985169"",
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
                    ""id"": ""b2037aea-4231-43ed-8f7e-9709c778f14f"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dfbe6a84-e776-4fbf-8d66-f7a521e98f8d"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1ba15617-3f28-4cc2-8fb9-4801793a28f1"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9623b921-89eb-4a16-b3b7-05bea5220b37"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""38dc6fe2-cbca-46d0-a9fc-baff24765851"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""1a10c5aa-2ee3-42c0-9a7c-339c7d79bc7a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2aef8c0d-73c7-4940-a827-b8c48e634af3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c4ac079b-ddf5-4e21-b170-2d267e35cbc0"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b1791be6-ebb1-417f-9da9-32dfc39b7def"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""efe917b7-2fa9-4aaf-bd2d-02727c823aba"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5131a2e4-2cd2-40eb-969d-b09577eeaeb9"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ResetPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6ab3785-ae26-4fa5-953b-c5207d7e8829"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/button13"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ResetPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b42a700c-8a6d-4757-9d5e-5a4561232f17"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8359ba7-911f-4ce9-b5f7-80c38b4f1047"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/hat/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5cbe0be2-0423-4762-9c57-75b032e2083d"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84031d08-d10a-4493-995a-43f5c302430c"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/hat/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""WaypointSetting"",
            ""id"": ""5171e260-fd09-4996-82a4-3468e17de30b"",
            ""actions"": [
                {
                    ""name"": ""SetWaypoint"",
                    ""type"": ""Button"",
                    ""id"": ""eb2ead19-c1c5-46cc-b2d2-30a9354f7955"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RemoveWaypoint"",
                    ""type"": ""Button"",
                    ""id"": ""89515798-18a1-4277-9401-d2a1244559bf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2e5f8c10-e547-4811-b1b1-3aa1b05c40ac"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/button8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetWaypoint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4bbeadd-b638-4ff0-9d20-90863a2cc208"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetWaypoint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43e00c9c-59c9-479e-9b0f-03bf664f4ee7"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/button7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RemoveWaypoint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae15c421-1d13-4206-b124-38bab5eaccec"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RemoveWaypoint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CameraMovementAndRotation
        m_CameraMovementAndRotation = asset.FindActionMap("CameraMovementAndRotation", throwIfNotFound: true);
        m_CameraMovementAndRotation_Movement = m_CameraMovementAndRotation.FindAction("Movement", throwIfNotFound: true);
        m_CameraMovementAndRotation_Rotation = m_CameraMovementAndRotation.FindAction("Rotation", throwIfNotFound: true);
        m_CameraMovementAndRotation_ResetPosition = m_CameraMovementAndRotation.FindAction("ResetPosition", throwIfNotFound: true);
        m_CameraMovementAndRotation_Up = m_CameraMovementAndRotation.FindAction("Up", throwIfNotFound: true);
        m_CameraMovementAndRotation_Down = m_CameraMovementAndRotation.FindAction("Down", throwIfNotFound: true);
        // WaypointSetting
        m_WaypointSetting = asset.FindActionMap("WaypointSetting", throwIfNotFound: true);
        m_WaypointSetting_SetWaypoint = m_WaypointSetting.FindAction("SetWaypoint", throwIfNotFound: true);
        m_WaypointSetting_RemoveWaypoint = m_WaypointSetting.FindAction("RemoveWaypoint", throwIfNotFound: true);
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

    // CameraMovementAndRotation
    private readonly InputActionMap m_CameraMovementAndRotation;
    private ICameraMovementAndRotationActions m_CameraMovementAndRotationActionsCallbackInterface;
    private readonly InputAction m_CameraMovementAndRotation_Movement;
    private readonly InputAction m_CameraMovementAndRotation_Rotation;
    private readonly InputAction m_CameraMovementAndRotation_ResetPosition;
    private readonly InputAction m_CameraMovementAndRotation_Up;
    private readonly InputAction m_CameraMovementAndRotation_Down;
    public struct CameraMovementAndRotationActions
    {
        private @SimulationControls m_Wrapper;
        public CameraMovementAndRotationActions(@SimulationControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_CameraMovementAndRotation_Movement;
        public InputAction @Rotation => m_Wrapper.m_CameraMovementAndRotation_Rotation;
        public InputAction @ResetPosition => m_Wrapper.m_CameraMovementAndRotation_ResetPosition;
        public InputAction @Up => m_Wrapper.m_CameraMovementAndRotation_Up;
        public InputAction @Down => m_Wrapper.m_CameraMovementAndRotation_Down;
        public InputActionMap Get() { return m_Wrapper.m_CameraMovementAndRotation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraMovementAndRotationActions set) { return set.Get(); }
        public void SetCallbacks(ICameraMovementAndRotationActions instance)
        {
            if (m_Wrapper.m_CameraMovementAndRotationActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CameraMovementAndRotationActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CameraMovementAndRotationActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CameraMovementAndRotationActionsCallbackInterface.OnMovement;
                @Rotation.started -= m_Wrapper.m_CameraMovementAndRotationActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_CameraMovementAndRotationActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_CameraMovementAndRotationActionsCallbackInterface.OnRotation;
                @ResetPosition.started -= m_Wrapper.m_CameraMovementAndRotationActionsCallbackInterface.OnResetPosition;
                @ResetPosition.performed -= m_Wrapper.m_CameraMovementAndRotationActionsCallbackInterface.OnResetPosition;
                @ResetPosition.canceled -= m_Wrapper.m_CameraMovementAndRotationActionsCallbackInterface.OnResetPosition;
                @Up.started -= m_Wrapper.m_CameraMovementAndRotationActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_CameraMovementAndRotationActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_CameraMovementAndRotationActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_CameraMovementAndRotationActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_CameraMovementAndRotationActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_CameraMovementAndRotationActionsCallbackInterface.OnDown;
            }
            m_Wrapper.m_CameraMovementAndRotationActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @ResetPosition.started += instance.OnResetPosition;
                @ResetPosition.performed += instance.OnResetPosition;
                @ResetPosition.canceled += instance.OnResetPosition;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
            }
        }
    }
    public CameraMovementAndRotationActions @CameraMovementAndRotation => new CameraMovementAndRotationActions(this);

    // WaypointSetting
    private readonly InputActionMap m_WaypointSetting;
    private IWaypointSettingActions m_WaypointSettingActionsCallbackInterface;
    private readonly InputAction m_WaypointSetting_SetWaypoint;
    private readonly InputAction m_WaypointSetting_RemoveWaypoint;
    public struct WaypointSettingActions
    {
        private @SimulationControls m_Wrapper;
        public WaypointSettingActions(@SimulationControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SetWaypoint => m_Wrapper.m_WaypointSetting_SetWaypoint;
        public InputAction @RemoveWaypoint => m_Wrapper.m_WaypointSetting_RemoveWaypoint;
        public InputActionMap Get() { return m_Wrapper.m_WaypointSetting; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WaypointSettingActions set) { return set.Get(); }
        public void SetCallbacks(IWaypointSettingActions instance)
        {
            if (m_Wrapper.m_WaypointSettingActionsCallbackInterface != null)
            {
                @SetWaypoint.started -= m_Wrapper.m_WaypointSettingActionsCallbackInterface.OnSetWaypoint;
                @SetWaypoint.performed -= m_Wrapper.m_WaypointSettingActionsCallbackInterface.OnSetWaypoint;
                @SetWaypoint.canceled -= m_Wrapper.m_WaypointSettingActionsCallbackInterface.OnSetWaypoint;
                @RemoveWaypoint.started -= m_Wrapper.m_WaypointSettingActionsCallbackInterface.OnRemoveWaypoint;
                @RemoveWaypoint.performed -= m_Wrapper.m_WaypointSettingActionsCallbackInterface.OnRemoveWaypoint;
                @RemoveWaypoint.canceled -= m_Wrapper.m_WaypointSettingActionsCallbackInterface.OnRemoveWaypoint;
            }
            m_Wrapper.m_WaypointSettingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SetWaypoint.started += instance.OnSetWaypoint;
                @SetWaypoint.performed += instance.OnSetWaypoint;
                @SetWaypoint.canceled += instance.OnSetWaypoint;
                @RemoveWaypoint.started += instance.OnRemoveWaypoint;
                @RemoveWaypoint.performed += instance.OnRemoveWaypoint;
                @RemoveWaypoint.canceled += instance.OnRemoveWaypoint;
            }
        }
    }
    public WaypointSettingActions @WaypointSetting => new WaypointSettingActions(this);
    public interface ICameraMovementAndRotationActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnResetPosition(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
    }
    public interface IWaypointSettingActions
    {
        void OnSetWaypoint(InputAction.CallbackContext context);
        void OnRemoveWaypoint(InputAction.CallbackContext context);
    }
}
