using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform = null;
    [SerializeField] private float verticalSpeed = 180;
    [SerializeField] private float horizontalSpeed = 180;

    private float verticalRotationAxis;
    private float horizontalRotationAxis;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update() => RotateCamera();

    private void RotateCamera()
    {
        verticalRotationAxis -= Input.GetAxis("Mouse Y") * verticalSpeed * Time.deltaTime;
        horizontalRotationAxis += Input.GetAxis("Mouse X") * horizontalSpeed * Time.deltaTime;

        verticalRotationAxis = Mathf.Clamp(verticalRotationAxis, -90, 90);
        cameraTransform.localEulerAngles = new Vector3(verticalRotationAxis, horizontalRotationAxis, 0);
    }
}