using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;

    SpriteRenderer sr;

    [SerializeField]
    private float moveSpeed;

    private Vector2 movementInput;

    float xMovement;
    float yMovement;

    private bool facingRight;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        // Inputs for Player Movements

        xMovement = Input.GetAxisRaw("Horizontal");
        yMovement = Input.GetAxisRaw("Vertical");

        if(xMovement == 0 && yMovement == 0)
        {
            rb.velocity = new Vector2(0, 0);

            return;
        }

        //for Flip character

        if (xMovement < 0) 
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }

        movementInput = new Vector2(xMovement, yMovement);
        rb.velocity = movementInput * moveSpeed * Time.fixedDeltaTime;
    }

}
