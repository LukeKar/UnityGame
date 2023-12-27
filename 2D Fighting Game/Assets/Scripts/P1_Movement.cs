using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1_Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    public GameObject GroundPoint;
    private bool isOnGround;
    public LayerMask whatIsGround;
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        moveSpeed = 9.0f;
        jumpForce = 20.0f;
    }

    // Update is called once per frame
    void Update()
    {
        isOnGround = Physics2D.OverlapCircle(GroundPoint.transform.position, 0.2f, whatIsGround);
        if (Input.GetButtonDown("Jump") && isOnGround) {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rb.velocity.y);
        //theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, theRB.velocity.y);

        
    }
}
