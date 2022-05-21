using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    [SerializeField] float playerSpeedModifier = 1f;
    [SerializeField] float playerJumpModifier = 10f;

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
    }

    public void SetCanJump(bool state)
    {
        canJump = state;
    }
}
