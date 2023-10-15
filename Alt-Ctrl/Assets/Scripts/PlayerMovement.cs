using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotationSpeed = 100.0f;
    private Rigidbody2D rb;
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            // Rotation
            float rotation = -horizontalInput * rotationSpeed * Time.deltaTime;
            transform.Rotate(0, 0, rotation);

            // Déplacement
            Vector2 movement = new Vector2(0, verticalInput);
            Vector3 moveDirection = (Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z) * movement).normalized;
            rb.AddForce(moveDirection * moveSpeed);
        }
}
