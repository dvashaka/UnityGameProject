using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;      // The object to follow (e.g. Player)
    public Vector3 offset;        // Offset from the target
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
    }
}
