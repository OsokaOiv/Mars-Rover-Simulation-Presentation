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
        }
    ],
    ""controlSchemes"": []
}");
        // ViewTransitions
        m_ViewTransitions = asset.FindActionMap("ViewTransitions", throwIfNotFound: true);
        m_ViewTransitions_NextView = m_ViewTransitions.FindAction("NextView", throwIfNotFound: true);
        m_ViewTransitions_PreviousView = m_ViewTransitions.FindAction("PreviousView", throwIfNotFound: true);
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
    public interface IViewTransitionsActions
    {
        void OnNextView(InputAction.CallbackContext context);
        void OnPreviousView(InputAction.CallbackContext context);
    }
}
