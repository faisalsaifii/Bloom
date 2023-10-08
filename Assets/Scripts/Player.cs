using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform groundCheck; 
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;

    public int jumpHeight;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);

        if (Input.GetMouseButtonDown(0))
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);    
    }
}
