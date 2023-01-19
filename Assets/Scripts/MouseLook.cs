using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    public InputActionReference horizontalLook;
    public InputActionReference verticalLook;
    public float lookSpeed = 1.0f;
    public Transform headCamTransform;

    float pitch;
    float yaw;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        horizontalLook.action.performed += HandleHorizontalLookChange;
        verticalLook.action.performed += HandleVerticalLookChange;
    }

    private void HandleHorizontalLookChange(InputAction.CallbackContext obj)
    {
        yaw += obj.ReadValue<float>();
        transform.localRotation = Quaternion.AngleAxis(yaw * lookSpeed, Vector3.up);
    }

    private void HandleVerticalLookChange(InputAction.CallbackContext obj)
    {
        pitch -= obj.ReadValue<float>();
        headCamTransform.localRotation = Quaternion.AngleAxis(pitch * lookSpeed, Vector3.right);

    }
}
