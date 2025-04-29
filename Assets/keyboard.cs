using UnityEngine;

public class KeyboardVRMovement : MonoBehaviour
{
    public float moveSpeed = 3f;

    void Update()
    {
        // Move using WASD (keyboard input)
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(moveX, 0, moveZ);
    }
}

