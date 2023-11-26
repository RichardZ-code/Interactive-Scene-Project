using UnityEngine;

public class BasicCameraControl : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float sensitivity = 5.0f;

    void LateUpdate()
    {
        if (target != null)
        {
            // Rotating the camera based on mouse movement
            float horizontal = Input.GetAxis("Mouse X") * sensitivity;
            float vertical = Input.GetAxis("Mouse Y") * sensitivity;
            transform.RotateAround(target.position, Vector3.up, horizontal);
            transform.RotateAround(target.position, transform.right, -vertical);

            // Keeping the camera at a fixed distance from the target
            transform.position = target.position - transform.forward * offset.z + transform.up * offset.y;
        }
    }
}