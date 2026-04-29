using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class MouseEvents : MonoBehaviour
{
    [SerializeField] private InputActionReference _clickAction;
    [SerializeField] private InputActionReference _moveAction;
    [SerializeField] private InputActionReference _deltaAction;

    public UnityEvent clickEvent;
    public UnityEvent<Vector2> moveEvent;
    public UnityEvent<Vector2> deltaEvent;

    void Awake()
    {
        _clickAction.action.performed += InvokeClickEvent;
        _moveAction.action.performed += InvokeMoveEvent;
        _deltaAction.action.performed += InvokeDeltaEvent;
    }

    private void InvokeClickEvent(InputAction.CallbackContext context)
    {
        clickEvent.Invoke();
    }

    private void InvokeMoveEvent(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        moveEvent.Invoke(input);
    }

    private void InvokeDeltaEvent(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        deltaEvent.Invoke(input);
    }

    private bool CheckForObject(Vector2 screenPosition, out GameObject found)
    {
        found = new();
        return false;
    }
}
