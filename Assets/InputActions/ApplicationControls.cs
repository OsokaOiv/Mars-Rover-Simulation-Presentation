// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/ApplicationControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ApplicationControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ApplicationControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ApplicationControls"",
    ""maps"": [
        {
            ""name"": ""General"",
            ""id"": ""82e5bdd7-8fbc-4c2d-a4a9-9288ac7992c0"",
            ""actions"": [
                {
                    ""name"": ""ExitApplication"",
                    ""type"": ""Button"",
                    ""id"": ""4479ca73-01fd-4bc8-939e-4a02dedb90c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ReloadActiveScene"",
                    ""type"": ""Button"",
                    ""id"": ""31a78079-0430-43bf-b4be-c14f1f4b76ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2cfbd0fc-de67-443d-ab65-c59de5892fea"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExitApplication"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f7aaa96-b9ea-4f63-b553-b59f462db5f0"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReloadActiveScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e7931cf-ab37-49d0-a78b-e2b70789478a"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/button14"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReloadActiveScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // General
        m_General = asset.FindActionMap("General", throwIfNotFound: true);
        m_General_ExitApplication = m_General.FindAction("ExitApplication", throwIfNotFound: true);
        m_General_ReloadActiveScene = m_General.FindAction("ReloadActiveScene", throwIfNotFound: true);
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

    // General
    private readonly InputActionMap m_General;
    private IGeneralActions m_GeneralActionsCallbackInterface;
    private readonly InputAction m_General_ExitApplication;
    private readonly InputAction m_General_ReloadActiveScene;
    public struct GeneralActions
    {
        private @ApplicationControls m_Wrapper;
        public GeneralActions(@ApplicationControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ExitApplication => m_Wrapper.m_General_ExitApplication;
        public InputAction @ReloadActiveScene => m_Wrapper.m_General_ReloadActiveScene;
        public InputActionMap Get() { return m_Wrapper.m_General; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GeneralActions set) { return set.Get(); }
        public void SetCallbacks(IGeneralActions instance)
        {
            if (m_Wrapper.m_GeneralActionsCallbackInterface != null)
            {
                @ExitApplication.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnExitApplication;
                @ExitApplication.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnExitApplication;
                @ExitApplication.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnExitApplication;
                @ReloadActiveScene.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnReloadActiveScene;
                @ReloadActiveScene.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnReloadActiveScene;
                @ReloadActiveScene.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnReloadActiveScene;
            }
            m_Wrapper.m_GeneralActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ExitApplication.started += instance.OnExitApplication;
                @ExitApplication.performed += instance.OnExitApplication;
                @ExitApplication.canceled += instance.OnExitApplication;
                @ReloadActiveScene.started += instance.OnReloadActiveScene;
                @ReloadActiveScene.performed += instance.OnReloadActiveScene;
                @ReloadActiveScene.canceled += instance.OnReloadActiveScene;
            }
        }
    }
    public GeneralActions @General => new GeneralActions(this);
    public interface IGeneralActions
    {
        void OnExitApplication(InputAction.CallbackContext context);
        void OnReloadActiveScene(InputAction.CallbackContext context);
    }
}
