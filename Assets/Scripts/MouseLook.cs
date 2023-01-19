using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private InputActionReference horizontalLook;
    [SerializeField] private InputActionReference verticalLook;
    [SerializeField] private float lookSpeed = 1.0f;
    [SerializeField] private Transform headCamTransform;

    float pitch;
    float yaw;
}
