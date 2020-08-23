using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0.3f;

    private Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var velocityX = speed * Time.deltaTime * x;
        rigidbody2D.velocity += new Vector2(velocityX, 0);
        //transform.position += transform.right * speed * Time.deltaTime * x;
    }
}
