using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CapsuleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
//autimatically add on collider and rigidbody 

public class PlayerMovement : MonoBehaviour

    //simple player physics
    //

   

{
    Rigidbody2D rb;

    [SerializeField]
    float jumpStrength = 5.0f;//jump power

    [SerializeField]
    float movementSpeed = 5.0f;

    [SerializeField]
    float moveX;

    bool canJump = false;
    bool isGrounded = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        //Debug.Log("hit", collision.gameObject);
    }


    private void PlayerControls() {

        moveX = Input.GetAxis("Horizontal");//virtual joystick 
        if (Input.GetKeyDown(KeyCode.Space)) {

            canJump = true;

        }
    
    }


    void Jump()
    {
        if (!isGrounded)
            return;
        isGrounded = false;
        rb.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
        // impulse only add force once

        //Debug.Log("Jump!!", gameObject);


        //if (isGrounded)
        //{

        //isGrounded = false;
        // rb.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
        //}
    }

    private void FixedUpdate()//this is the update for objects with physics 
    {
        rb.velocity = new Vector2(moveX * movementSpeed, rb.velocity.y);
        if (canJump == true) {
            canJump = false;
            Jump();
        }
    }


    private void Update()
    {
        PlayerControls();
    }

}
