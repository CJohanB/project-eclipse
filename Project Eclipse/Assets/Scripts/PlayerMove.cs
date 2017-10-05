using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour {

    public int maxSpeed;
    public int jumpForce;

    private bool facingRight = true;

    public Rigidbody2D rgb;

    // Use this for initialization
    void Start () {
        rgb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

    public void Move(float move, bool jump)
    {
        rgb.velocity = new Vector2(move * maxSpeed, rgb.velocity.y);

        if (jump)
        {
            rgb.velocity = new Vector2(0, jumpForce);
        }

        if (move > 0 && !facingRight)
        {
            Flip();
        }

        if (move < 0 && facingRight)
        {
            Flip();
        }
    }

    private void Flip()
    {
        facingRight = !facingRight;

        Vector3 newScale = transform.localScale;
        newScale.x *= -1;
        transform.localScale = newScale;
    }
}
