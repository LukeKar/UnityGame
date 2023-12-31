using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_Movement : MonoBehaviour {
    public Rigidbody2D rb2;
    public Animator animator;
    public static P2_Movement instance;
    public bool isAttacking = false;
    [SerializeField] private float moveSpeed2;
    [SerializeField] private float jumpForce2;
    public GameObject GroundPoint;
    private bool isOnGround;
    public LayerMask whatIsGround;
    private void Awake() {
        rb2 = GetComponent<Rigidbody2D>();
        instance = this;
        animator = GetComponent<Animator>();
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



        attack();        

         if (moveInput2 != 0){
            animator.SetBool("Iswalking", true);
                if (moveInput2 > 0){
                    gameObject.transform.localScale = new Vector3(5, 5, 1);
                }
                if (moveInput2 < 0){
                    gameObject.transform.localScale = new Vector3(-5, 5, 1);  
                }
            
         }else{
            animator.SetBool("Iswalking", false);
         }
        
        
    }



    void attack()
    {
        if (Input.GetKeyDown(KeyCode.Comma) && !isAttacking)
        {
            isAttacking = true;
        }
    }



}
