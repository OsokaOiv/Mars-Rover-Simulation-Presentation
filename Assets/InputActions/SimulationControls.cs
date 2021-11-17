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
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""91fc1025-0966-4b8c-bda4-9128b427033e"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/hat"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
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
    public struct CameraMovementAndRotationActions
    {
        private @SimulationControls m_Wrapper;
        public CameraMovementAndRotationActions(@SimulationControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_CameraMovementAndRotation_Movement;
        public InputAction @Rotation => m_Wrapper.m_CameraMovementAndRotation_Rotation;
        public InputAction @ResetPosition => m_Wrapper.m_CameraMovementAndRotation_ResetPosition;
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
    }
    public interface IWaypointSettingActions
    {
        void OnSetWaypoint(InputAction.CallbackContext context);
        void OnRemoveWaypoint(InputAction.CallbackContext context);
    }
}
