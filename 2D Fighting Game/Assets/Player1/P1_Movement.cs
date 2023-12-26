using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1_Movement : MonoBehaviour
{
    public Rigidbody2D rb2;
    public float moveSpeed = 8.0f;

    private void Awake() {
        this.rb2 = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.rb2.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rb2.velocity.y);
    }
}
