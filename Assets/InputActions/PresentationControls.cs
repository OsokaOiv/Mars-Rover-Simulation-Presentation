// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/PresentationControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PresentationControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PresentationControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PresentationControls"",
    ""maps"": [
        {
            ""name"": ""ViewTransitions"",
            ""id"": ""8242941c-9bc8-4346-b2c2-458a535a7c96"",
            ""actions"": [
                {
                    ""name"": ""NextView"",
                    ""type"": ""Button"",
                    ""id"": ""e688c320-75c3-4f36-b0af-45d212a269df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PreviousView"",
                    ""type"": ""Button"",
                    ""id"": ""af9f9297-9161-47eb-992d-658781c48a0d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b551af09-4a9f-4315-93ff-964e8402240d"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71b320bc-6b55-41f9-af83-da0423999704"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6d2d4e7-eb37-46d7-9345-a9c54ec1870a"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PreviousView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e99397b-5eba-4219-a9d8-40a4b2abe05f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PreviousView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""LagDemo"",
            ""id"": ""74c1fad9-9e02-4aae-806a-8c625459eb99"",
            ""actions"": [
                {
                    ""name"": ""ForwardWithLag"",
                    ""type"": ""Button"",
                    ""id"": ""5d768e6e-7477-42c7-8545-1618e4df1c6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""76599040-8283-47ba-bac1-00fc8b62e8d5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardWithLag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df256120-b1fc-4c52-a088-50d060681b01"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardWithLag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ViewTransitions
        m_ViewTransitions = asset.FindActionMap("ViewTransitions", throwIfNotFound: true);
        m_ViewTransitions_NextView = m_ViewTransitions.FindAction("NextView", throwIfNotFound: true);
        m_ViewTransitions_PreviousView = m_ViewTransitions.FindAction("PreviousView", throwIfNotFound: true);
        // LagDemo
        m_LagDemo = asset.FindActionMap("LagDemo", throwIfNotFound: true);
        m_LagDemo_ForwardWithLag = m_LagDemo.FindAction("ForwardWithLag", throwIfNotFound: true);
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

    // ViewTransitions
    private readonly InputActionMap m_ViewTransitions;
    private IViewTransitionsActions m_ViewTransitionsActionsCallbackInterface;
    private readonly InputAction m_ViewTransitions_NextView;
    private readonly InputAction m_ViewTransitions_PreviousView;
    public struct ViewTransitionsActions
    {
        private @PresentationControls m_Wrapper;
        public ViewTransitionsActions(@PresentationControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @NextView => m_Wrapper.m_ViewTransitions_NextView;
        public InputAction @PreviousView => m_Wrapper.m_ViewTransitions_PreviousView;
        public InputActionMap Get() { return m_Wrapper.m_ViewTransitions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ViewTransitionsActions set) { return set.Get(); }
        public void SetCallbacks(IViewTransitionsActions instance)
        {
            if (m_Wrapper.m_ViewTransitionsActionsCallbackInterface != null)
            {
                @NextView.started -= m_Wrapper.m_ViewTransitionsActionsCallbackInterface.OnNextView;
                @NextView.performed -= m_Wrapper.m_ViewTransitionsActionsCallbackInterface.OnNextView;
                @NextView.canceled -= m_Wrapper.m_ViewTransitionsActionsCallbackInterface.OnNextView;
                @PreviousView.started -= m_Wrapper.m_ViewTransitionsActionsCallbackInterface.OnPreviousView;
                @PreviousView.performed -= m_Wrapper.m_ViewTransitionsActionsCallbackInterface.OnPreviousView;
                @PreviousView.canceled -= m_Wrapper.m_ViewTransitionsActionsCallbackInterface.OnPreviousView;
            }
            m_Wrapper.m_ViewTransitionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @NextView.started += instance.OnNextView;
                @NextView.performed += instance.OnNextView;
                @NextView.canceled += instance.OnNextView;
                @PreviousView.started += instance.OnPreviousView;
                @PreviousView.performed += instance.OnPreviousView;
                @PreviousView.canceled += instance.OnPreviousView;
            }
        }
    }
    public ViewTransitionsActions @ViewTransitions => new ViewTransitionsActions(this);

    // LagDemo
    private readonly InputActionMap m_LagDemo;
    private ILagDemoActions m_LagDemoActionsCallbackInterface;
    private readonly InputAction m_LagDemo_ForwardWithLag;
    public struct LagDemoActions
    {
        private @PresentationControls m_Wrapper;
        public LagDemoActions(@PresentationControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ForwardWithLag => m_Wrapper.m_LagDemo_ForwardWithLag;
        public InputActionMap Get() { return m_Wrapper.m_LagDemo; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LagDemoActions set) { return set.Get(); }
        public void SetCallbacks(ILagDemoActions instance)
        {
            if (m_Wrapper.m_LagDemoActionsCallbackInterface != null)
            {
                @ForwardWithLag.started -= m_Wrapper.m_LagDemoActionsCallbackInterface.OnForwardWithLag;
                @ForwardWithLag.performed -= m_Wrapper.m_LagDemoActionsCallbackInterface.OnForwardWithLag;
                @ForwardWithLag.canceled -= m_Wrapper.m_LagDemoActionsCallbackInterface.OnForwardWithLag;
            }
            m_Wrapper.m_LagDemoActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ForwardWithLag.started += instance.OnForwardWithLag;
                @ForwardWithLag.performed += instance.OnForwardWithLag;
                @ForwardWithLag.canceled += instance.OnForwardWithLag;
            }
        }
    }
    public LagDemoActions @LagDemo => new LagDemoActions(this);
    public interface IViewTransitionsActions
    {
        void OnNextView(InputAction.CallbackContext context);
        void OnPreviousView(InputAction.CallbackContext context);
    }
    public interface ILagDemoActions
    {
        void OnForwardWithLag(InputAction.CallbackContext context);
    }
}
