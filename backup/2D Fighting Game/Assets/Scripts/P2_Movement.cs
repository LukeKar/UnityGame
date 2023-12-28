using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_Movement : MonoBehaviour {
    public Rigidbody2D rb2;
    public Animator animator;
    [SerializeField] private float moveSpeed2;
    [SerializeField] private float jumpForce2;
    public GameObject GroundPoint;
    private bool isOnGround;
    public LayerMask whatIsGround;
    private void Awake() {
        rb2 = GetComponent<Rigidbody2D>();
    }
    void Start() {
        moveSpeed2 = 9.0f;
        jumpForce2 = 20.0f;
    }

    // Update is called once per frame
    void Update() {


        isOnGround = Physics2D.OverlapCircle(GroundPoint.transform.position, 0.2f, whatIsGround);
        if (Input.GetButtonDown("Jump2") && isOnGround) {
            rb2.velocity = new Vector2(rb2.velocity.x, jumpForce2);
        }


        if (isOnGround == true){
            animator.SetBool("Isjumping", false);
        }
        else{
            animator.SetBool("Isjumping", true);
        }

        float moveInput2 = Input.GetAxisRaw("HorizontalArrows") * moveSpeed2;
        rb2.velocity = new Vector2(Input.GetAxisRaw("HorizontalArrows") * moveSpeed2, rb2.velocity.y);

        //theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, theRB.velocity.y);


         if (moveInput2 != 0){
            animator.SetBool("Iswalking", true);
        }
        else{
            animator.SetBool("Iswalking", false);
        }
        
        
    }
}
