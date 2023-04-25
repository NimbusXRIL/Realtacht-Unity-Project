using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void LateUpdate()
    {
        // Get the position of the camera
        Vector3 cameraPosition = _camera.transform.position;

        // Calculate the vector from the quad to the camera
        Vector3 quadToCamera = cameraPosition - transform.position;

        // Calculate the rotation that would align the quad's forward vector with the quad-to-camera vector
        Quaternion lookRotation = Quaternion.LookRotation(quadToCamera, Vector3.up);

        // Apply the rotation to the quad
        transform.rotation = lookRotation;
    }
}
