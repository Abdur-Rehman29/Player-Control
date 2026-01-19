using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private InputSystem_Actions _InputSystem;
    public Vector2 _InputX;
    private void Awake()
    {
        _InputSystem = new InputSystem_Actions();
        _InputSystem.Player.Move.performed += Move_performed;
        _InputSystem.Player.Move.canceled += Move_canceled;
    }

    private void Move_canceled(InputAction.CallbackContext obj)
    {
        _InputX = Vector2.zero;
    }

    private void Move_performed(InputAction.CallbackContext obj)
    {
        _InputX = obj.ReadValue<Vector2>();
    }

    private void OnEnable()
    {
        _InputSystem.Player.Enable();
    }
    private void OnDisable()
    {
        _InputSystem.Player.Disable();
    }
    private void OnDestroy()
    {
        _InputSystem.Player.Move.performed -= Move_performed;
        _InputSystem.Player.Move.canceled -= Move_canceled;
    }

}
