using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_Movement : MonoBehaviour {
    public Rigidbody2D rb2;
    [SerializeField] private float moveSpeed2;
    [SerializeField] private float jumpForce2;
    public string requiredTag2 = "Player2";
    private void Awake() {
        rb2 = GetComponent<Rigidbody2D>();
    }
    void Start() {
        moveSpeed2 = 9.0f;
        jumpForce2 = 20.0f;
    }

    // Update is called once per frame
    void Update() {
        
        rb2.velocity = new Vector2(Input.GetAxisRaw("HorizontalArrows") * moveSpeed2, rb2.velocity.y);
        //theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, theRB.velocity.y);
        if (Input.GetButtonDown("Jump2")) {
            rb2.velocity = new Vector2(rb2.velocity.x, jumpForce2);
        }
        
    }
}
