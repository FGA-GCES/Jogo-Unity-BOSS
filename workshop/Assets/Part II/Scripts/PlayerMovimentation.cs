using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PartII {
	public class PlayerMovimentation : MonoBehaviour
	{
		// Public attributes
		public float maxSpeed = 5;

		// Private attributes
		Rigidbody2D rigidBody;

		// Start is called before the first frame update
		// Here you can handle with all objects in the scene
		void Start()
		{
		}

		// Awake is called before the first frame update
		// Here you can handle with all components in the object
		void Awake()
		{
			rigidBody = GetComponent<Rigidbody2D>();
		}

		// Update is called once per frame
		void Update()
		{
			var x = Input.GetAxis("Horizontal");
			// transform.position += x * maxSpeed * transform.right * Time.deltaTime;
			rigidBody.velocity = new Vector2(x * maxSpeed, rigidBody.velocity.y);
		}
	}
}
