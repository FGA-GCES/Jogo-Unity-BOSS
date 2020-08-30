using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimentation : MonoBehaviour
{
	// Public attributes
	public float maxSpeed = 5;
	public float jumpSpeed = 5;

	// Private attributes
	private Rigidbody2D rigidBody;
	private bool isJumping = false;

	// Start is called before the first frame update
	// Here you can handle with all objects in the scene
	void Start()
	{
	}

	// Awake is called before the first frame update
	// Here you can handle with all components in the object
	private void Awake()
	{
		rigidBody = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		var x = Input.GetAxis("Horizontal");
		// transform.position += x * maxSpeed * transform.right * Time.deltaTime;
		rigidBody.velocity = new Vector2(x * maxSpeed, rigidBody.velocity.y);

		var jump = Input.GetAxis("Jump");
		if (jump > 0.5 && !isJumping)
		{
			isJumping = true;
			rigidBody.velocity = new Vector2(rigidBody.velocity.x, jump * jumpSpeed);
		}
	}
}
