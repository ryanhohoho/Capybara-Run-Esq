//Create a camera movement script for a 3D camera that eaeses into the direction of the player's movement and rotates with the player, zooming in and out when clipping through walls. gameObject player is called player

using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public GameObject player;
    public float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        Vector3 targetPosition = player.transform.position + player.transform.forward * 4;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);


        transform.LookAt(player.transform);
        // Zoom in and out as the player moves through walls
        // Add code here for collision detection and zooming

    }
}