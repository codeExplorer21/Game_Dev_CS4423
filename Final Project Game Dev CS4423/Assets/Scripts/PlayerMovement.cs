using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;
    private BoxCollider2D boxColl;
    private float dirX;
    [SerializeField] private float playerMoveSpeed = 7f;
    [SerializeField] private float playerJumpForce = 7f;
    [SerializeField] private LayerMask jumpableGround;

    //This enum is to hold all the states of player animation
    private enum MovementState {idle, running, jumping, falling }

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        boxColl = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update()
    {
      dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * playerMoveSpeed, rb.velocity.y);
      
      if(Input.GetKeyDown("space") && Grounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, playerJumpForce);
        }

        UpdateAnimation();

    }

    //Function updateAnimation holds player animation conditions
    private void UpdateAnimation()
    {
        MovementState state;
        //this if statements change the animation of the player
        if (dirX > 0f) //character running right
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if (dirX < 0f) //player running left
        {
            state = MovementState.running;
            sprite.flipX = true;
        }
        else //player not moving
        {
            state = MovementState.idle;
        }

        //player jumping animation
        if(rb.velocity.y > .1f) //player jumping
        {
            state = MovementState.jumping;
        }
        else if(rb.velocity.y < -.1f) //player falling
        {
            state = MovementState.falling;
        }

        //update animation calling
        anim.SetInteger("state", (int)state);
    }

    //This function keeps player from doing multiple jumps
    private bool Grounded()
    {
        return Physics2D.BoxCast(boxColl.bounds.center, boxColl.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
