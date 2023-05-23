//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Input/UIAct.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @UIAct : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @UIAct()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UIAct"",
    ""maps"": [
        {
            ""name"": ""UI"",
            ""id"": ""0b1e5e69-dc7b-445e-ab64-569776aab6a7"",
            ""actions"": [
                {
                    ""name"": ""Esc"",
                    ""type"": ""Button"",
                    ""id"": ""12cfbd26-ba4d-452e-8f13-b4b803de4d1e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""KeySet"",
                    ""type"": ""Button"",
                    ""id"": ""ecb729b0-a772-4dec-97c2-67182f6941c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a2b88826-2f83-4fed-8a3d-46f42dc36d35"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Esc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8768e506-d45a-4a88-914b-a6765232a0e4"",
                    ""path"": ""<Keyboard>/f11"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeySet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""UI"",
            ""bindingGroup"": ""UI"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Esc = m_UI.FindAction("Esc", throwIfNotFound: true);
        m_UI_KeySet = m_UI.FindAction("KeySet", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Esc;
    private readonly InputAction m_UI_KeySet;
    public struct UIActions
    {
        private @UIAct m_Wrapper;
        public UIActions(@UIAct wrapper) { m_Wrapper = wrapper; }
        public InputAction @Esc => m_Wrapper.m_UI_Esc;
        public InputAction @KeySet => m_Wrapper.m_UI_KeySet;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Esc.started -= m_Wrapper.m_UIActionsCallbackInterface.OnEsc;
                @Esc.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnEsc;
                @Esc.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnEsc;
                @KeySet.started -= m_Wrapper.m_UIActionsCallbackInterface.OnKeySet;
                @KeySet.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnKeySet;
                @KeySet.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnKeySet;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Esc.started += instance.OnEsc;
                @Esc.performed += instance.OnEsc;
                @Esc.canceled += instance.OnEsc;
                @KeySet.started += instance.OnKeySet;
                @KeySet.performed += instance.OnKeySet;
                @KeySet.canceled += instance.OnKeySet;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_UISchemeIndex = -1;
    public InputControlScheme UIScheme
    {
        get
        {
            if (m_UISchemeIndex == -1) m_UISchemeIndex = asset.FindControlSchemeIndex("UI");
            return asset.controlSchemes[m_UISchemeIndex];
        }
    }
    public interface IUIActions
    {
        void OnEsc(InputAction.CallbackContext context);
        void OnKeySet(InputAction.CallbackContext context);
    }
}