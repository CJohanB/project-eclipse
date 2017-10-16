using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour {

    public GameObject player;
    private Rigidbody2D rb;
    public LayerMask layerMask;
    public Vector3 speed;
    public bool facingRight = true;


    // Use this for initialization
    void Start () {
       rb = GetComponent<Rigidbody2D>();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Obstacle")
        {
            Debug.Log("JAG HATAR LIVET!");
           // if (Vector3.Distance(transform.position, other.transform.position) > 2)
            //{
                rb.AddForce(new Vector3(0, 1000, 0));
           // }

        }
    }

    // Update is called once per frame
    void FixedUpdate () {
        float dis = Vector3.Distance(transform.position, player.transform.position);
        //Debug.Log(dis);

        Vector3 dir = (player.transform.position - transform.position);

        rb.AddForce(dir * 2);

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
