using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    [SerializeField] float playerSpeedModifier = 1f;
    [SerializeField] float playerJumpModifier = 35f;
    [SerializeField] float normalGravityScale = 1f;
    [SerializeField] float fallingGravityScale = 4f;

    Rigidbody2D rb2d;
    bool isAlive = true;
    bool canJump = true;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
	{
        if(isAlive){
		HandleHorizontalInput();
        HandleJump();
        }

	}

	void HandleJump()
	{
        Vector2 jumpImpulse = Vector2.up * playerJumpModifier;

        if(canJump)
        {
		    if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb2d.AddForce(jumpImpulse, ForceMode2D.Impulse);
                canJump = false;
            }
        }
        if(rb2d.velocity.y >= 0)
        {
            rb2d.gravityScale = normalGravityScale;
        }
        else if(rb2d.velocity.y < 0)
        {
            rb2d.gravityScale = fallingGravityScale;
        }

	}

	void HandleHorizontalInput()
	{
		// Create appropriate vector2
		Vector2 xInput = playerSpeedModifier * Input.GetAxis("Horizontal") * Vector2.right * Time.deltaTime * 1000;
        // Move the current player instance
		rb2d.AddForce(xInput);
	}

    public void KillPlayer()
    {
        isAlive = false;
        rb2d.drag = 1;
        rb2d.gravityScale = fallingGravityScale;
    }

    public void SetCanJump(bool state)
    {
        canJump = state;
    }
}
