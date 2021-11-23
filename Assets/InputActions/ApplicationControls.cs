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
                },
                {
                    ""name"": ""NextScene"",
                    ""type"": ""Button"",
                    ""id"": ""29d15de2-d132-4b54-97ca-b0b1fa7acc84"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PreviousScene"",
                    ""type"": ""Button"",
                    ""id"": ""7d223987-4980-43a2-a28c-76afa6a5f7c2"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""92e9dcbc-4955-4954-92e6-906462006c96"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1453c3da-19ee-442a-a339-898561080d1e"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/button10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54a877e1-8f97-413a-ada5-e34213f3a6d2"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PreviousScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""869e1f8c-c222-4c3e-b2e4-da280e8a8183"",
                    ""path"": ""<HID::Bensussen Deutsch & Associates,Inc.(BDA) Core (Plus) Wired Controller>/button9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PreviousScene"",
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
        m_General_NextScene = m_General.FindAction("NextScene", throwIfNotFound: true);
        m_General_PreviousScene = m_General.FindAction("PreviousScene", throwIfNotFound: true);
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
    private readonly InputAction m_General_NextScene;
    private readonly InputAction m_General_PreviousScene;
    public struct GeneralActions
    {
        private @ApplicationControls m_Wrapper;
        public GeneralActions(@ApplicationControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ExitApplication => m_Wrapper.m_General_ExitApplication;
        public InputAction @ReloadActiveScene => m_Wrapper.m_General_ReloadActiveScene;
        public InputAction @NextScene => m_Wrapper.m_General_NextScene;
        public InputAction @PreviousScene => m_Wrapper.m_General_PreviousScene;
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
                @NextScene.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnNextScene;
                @NextScene.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnNextScene;
                @NextScene.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnNextScene;
                @PreviousScene.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPreviousScene;
                @PreviousScene.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPreviousScene;
                @PreviousScene.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPreviousScene;
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
                @NextScene.started += instance.OnNextScene;
                @NextScene.performed += instance.OnNextScene;
                @NextScene.canceled += instance.OnNextScene;
                @PreviousScene.started += instance.OnPreviousScene;
                @PreviousScene.performed += instance.OnPreviousScene;
                @PreviousScene.canceled += instance.OnPreviousScene;
            }
        }
    }
    public GeneralActions @General => new GeneralActions(this);
    public interface IGeneralActions
    {
        void OnExitApplication(InputAction.CallbackContext context);
        void OnReloadActiveScene(InputAction.CallbackContext context);
        void OnNextScene(InputAction.CallbackContext context);
        void OnPreviousScene(InputAction.CallbackContext context);
    }
}
