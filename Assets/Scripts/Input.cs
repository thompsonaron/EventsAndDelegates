// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Input : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""BasicActions"",
            ""id"": ""50657100-d28b-434f-99f8-acac4d206e50"",
            ""actions"": [
                {
                    ""name"": ""SpaceActivation"",
                    ""type"": ""Button"",
                    ""id"": ""e17b8772-1421-4d6e-9837-04c4eaf7b84b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f772777c-c9a7-4fc9-b2ac-da1c736018a3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpaceActivation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BasicActions
        m_BasicActions = asset.FindActionMap("BasicActions", throwIfNotFound: true);
        m_BasicActions_SpaceActivation = m_BasicActions.FindAction("SpaceActivation", throwIfNotFound: true);
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

    // BasicActions
    private readonly InputActionMap m_BasicActions;
    private IBasicActionsActions m_BasicActionsActionsCallbackInterface;
    private readonly InputAction m_BasicActions_SpaceActivation;
    public struct BasicActionsActions
    {
        private @Input m_Wrapper;
        public BasicActionsActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @SpaceActivation => m_Wrapper.m_BasicActions_SpaceActivation;
        public InputActionMap Get() { return m_Wrapper.m_BasicActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BasicActionsActions set) { return set.Get(); }
        public void SetCallbacks(IBasicActionsActions instance)
        {
            if (m_Wrapper.m_BasicActionsActionsCallbackInterface != null)
            {
                @SpaceActivation.started -= m_Wrapper.m_BasicActionsActionsCallbackInterface.OnSpaceActivation;
                @SpaceActivation.performed -= m_Wrapper.m_BasicActionsActionsCallbackInterface.OnSpaceActivation;
                @SpaceActivation.canceled -= m_Wrapper.m_BasicActionsActionsCallbackInterface.OnSpaceActivation;
            }
            m_Wrapper.m_BasicActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SpaceActivation.started += instance.OnSpaceActivation;
                @SpaceActivation.performed += instance.OnSpaceActivation;
                @SpaceActivation.canceled += instance.OnSpaceActivation;
            }
        }
    }
    public BasicActionsActions @BasicActions => new BasicActionsActions(this);
    public interface IBasicActionsActions
    {
        void OnSpaceActivation(InputAction.CallbackContext context);
    }
}
