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
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b551af09-4a9f-4315-93ff-964e8402240d"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextView"",
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
    public struct ViewTransitionsActions
    {
        private @PresentationControls m_Wrapper;
        public ViewTransitionsActions(@PresentationControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @NextView => m_Wrapper.m_ViewTransitions_NextView;
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
            }
            m_Wrapper.m_ViewTransitionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @NextView.started += instance.OnNextView;
                @NextView.performed += instance.OnNextView;
                @NextView.canceled += instance.OnNextView;
            }
        }
    }
    public ViewTransitionsActions @ViewTransitions => new ViewTransitionsActions(this);
    public interface IViewTransitionsActions
    {
        void OnNextView(InputAction.CallbackContext context);
    }
}
