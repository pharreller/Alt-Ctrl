using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private Rigidbody2D rb;
    private Vector2 movement;
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }
    
        void Update()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
    
            movement = new Vector2(horizontalInput, verticalInput);
            rb.velocity = movement.normalized * moveSpeed;
        }
        void FixedUpdate()
            {
                rb.velocity = movement.normalized * moveSpeed;
            }
}
