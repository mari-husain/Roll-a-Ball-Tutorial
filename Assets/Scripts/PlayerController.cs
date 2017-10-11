using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb; // the rigidbody representing the player

	public float speed; // the player's movement speed

	// the start code. 
	// called when the first frame of the game is active.
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Update() is called before rendering a frame.
	// This is where most of our game code will go.
	void Update ()
	{
		
	}

	// FixedUpdate() is called before performing any physics calculations.
	// This is where our physics code will go.
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
}
