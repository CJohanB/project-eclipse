using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour {

    public GameObject player;
    private Rigidbody2D rb;
    public LayerMask layerMask;
    public Vector3 speed;
    public bool facingRight = true;
    public int force;


    // Use this for initialization
    void Start () {
       rb = GetComponent<Rigidbody2D>();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Obstacle")
        {
          
           // if (Vector3.Distance(transform.position, other.transform.position) > 2)
            //{
                rb.AddForce(new Vector3(0, force, 0));
           // }

        }
    }

    // Update is called once per frame
    void FixedUpdate () {
        float dis = Vector3.Distance(transform.position, player.transform.position);
        //Debug.Log(dis);

        Vector3 dir = (player.transform.position - transform.position);

        rb.AddForce(dir);

        if (dir.x > 0 && !facingRight)
        {
            Flip();
        }

        if (dir.x < 0 && facingRight)
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
