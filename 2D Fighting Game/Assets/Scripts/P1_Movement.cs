using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1_Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    public static P1_Movement instance;
    public bool isAttacking = false;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    public GameObject GroundPoint;
    private bool isOnGround;
    public LayerMask whatIsGround;
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        instance = this;
        animator = GetComponent<Animator>();
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
        
        if (isOnGround == true){
            animator.SetBool("Is_jumping", false);
        }
        else{
            animator.SetBool("Is_jumping", true);
        }


        float moveInput = Input.GetAxisRaw("Horizontal") * moveSpeed;
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rb.velocity.y);


        attack();


        if (moveInput != 0){
            animator.SetBool("Is_walking", true);
            if (moveInput > 0){
                gameObject.transform.localScale = new Vector3(5, 5, 1);
            }
            if (moveInput < 0){
                gameObject.transform.localScale = new Vector3(-5, 5, 1);  
            }
        }
        else{
            animator.SetBool("Is_walking", false);
        }

        //theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, theRB.velocity.y);

        
        void attack()
        {
            if (Input.GetKeyDown(KeyCode.Z) && !isAttacking)
            {
                isAttacking = true;
            }
        }



    }
}
