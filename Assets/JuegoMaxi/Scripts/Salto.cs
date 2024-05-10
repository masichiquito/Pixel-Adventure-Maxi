using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    // Speed of the jump
    public float jumpSpeed = 2f;

    // Flag to control if the object is jumping
    private bool isJumping = false;

    // Reference to the Coroutine handling the jump
    private Coroutine jumpCoroutine;

    void Update()
    {
        // Check for input to trigger jump
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            // Start the jump
            isJumping = true;
            // Call Jump coroutine
            jumpCoroutine = StartCoroutine(Jump());
        }
        else if (Input.GetKeyUp(KeyCode.Space) && isJumping)
        {
            // If space is released, stop the jump
            StopJump();
        }
    }

    IEnumerator Jump()
    {
        // Get the current position of the object
        Vector2 startPos = transform.position;
        // Calculate the target position for the jump (2 pixels above the current position)
        Vector2 targetPos = startPos + Vector2.up * 2f;

        // Move the object towards the target position
        while ((Vector2)transform.position != targetPos)
        {
            // Move the object towards the target position
            transform.position = Vector2.MoveTowards(transform.position, targetPos, jumpSpeed * Time.deltaTime);
            // Yield until the next frame
            yield return null;
        }

        // Once the jump is completed, reset the flag
        isJumping = false;
    }

    void StopJump()
    {
        // If the jump is currently in progress, stop it
        if (jumpCoroutine != null)
        {
            StopCoroutine(jumpCoroutine);
            isJumping = false;
        }
    }
}
