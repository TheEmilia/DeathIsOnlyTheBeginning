using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    [SerializeField] float playerSpeedModifier = 1f;

    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
	{
		HandleHorizontalInput();

	}

	void HandleHorizontalInput()
	{
		// Create appropriate vector2
		Vector2 xInput = playerSpeedModifier * Input.GetAxis("Horizontal") * Vector2.right * Time.deltaTime * 1000;
        // Move the current player instance
		rb2d.AddForce(xInput);
	}
}
