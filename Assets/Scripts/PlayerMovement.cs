using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;                // Constant forward speed
    public float jumpForce = 10f;               // Jump force
    public Transform groundCheckPoint;          // A point to check if the player is grounded
    public float checkRadius = 0.2f;            // Radius of the overlap circle for ground detection
    public LayerMask groundLayer;               // Layer of the ground objects
    public int doubleJump = 1;

    private Rigidbody2D rb;                     // Reference to the Rigidbody2D component
    private bool isGrounded;                    // Is the player on the ground?
    
    public AudioClip jump;
    public AudioSource playerSFX;
    Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();       // Get the Rigidbody2D component attached to the player
        playerSFX = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //ConstantForce forward movement
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        //Check if the player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, checkRadius, groundLayer);

        //Jumping logic
        if (doubleJump == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            playerSFX.PlayOneShot(jump);
            Jump();
            doubleJump = doubleJump - 1;
        }

        if (isGrounded == true)
        {
            doubleJump = 1;
        }

        anim.SetBool("IsOnGround", isGrounded);
    }
    
    private void Jump()
    {
        //Add an upward force for jumping
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void OnDrawGizmosSelected()
    {
        //Draw a circle to visualize the ground check point in the editor
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckPoint.position, checkRadius);
    }
}
