using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class MouseEvents : MonoBehaviour
{
    [SerializeField] private InputAction _clickAction;
    [SerializeField] private InputAction _moveAction;
    [SerializeField] private InputAction _deltaAction;

    public UnityEvent clickEvent;
    public UnityEvent<Vector2> moveEvent;
    public UnityEvent<Vector2> deltaEvent;

    void Awake()
    {

    }
}
