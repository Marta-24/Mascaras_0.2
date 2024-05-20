using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public Vector3 offset;   // Offset from the player's position

    void Start()
    {
        // Initialize the offset based on the current positions of the player and the camera
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        // Update the camera's position based on the player's position and the offset
        transform.position = player.position + offset;
    }
}
