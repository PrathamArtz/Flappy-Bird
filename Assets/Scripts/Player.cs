using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _jumpForce = 1.5f;
    [SerializeField]
    private Rigidbody2D _rb;
    [SerializeField]
    private float _rotationSpeed = 10.0f;
    // Update is called once per frame
    private void FixedUpdate()
    {
        /*
        float jumpInput = Input.GetAxis("Jump");

        transform.Translate(Vector3.up * jumpInput * _jumpForce * Time.deltaTime); */
       

        if (Input.GetKey("space"))
        {
            _rb.velocity = Vector2.up * _jumpForce;
        }

        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed);
    }


   
}
