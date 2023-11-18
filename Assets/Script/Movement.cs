using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f; // Adjust this to set the movement speed

    void Update()
    {
        // Get input values for horizontal and vertical axes
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * speed * Time.deltaTime;

        // Move the player
        transform.Translate(movement);
    }
}