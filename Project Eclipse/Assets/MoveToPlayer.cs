using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour {

    public GameObject player;
    private Rigidbody2D rb;
    public LayerMask layerMask;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float dis = Vector3.Distance(transform.position, player.transform.position);
        Debug.Log(dis);
  
        Vector3 dir = (player.transform.position - transform.position);
       
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, layerMask);

        Debug.Log(hit.transform.name);
        if (hit.collider.tag == "Obstacle" && Vector3.Distance (transform.position, hit.transform.position) > 2)
        {
            rb.AddForce(Vector3.up);
        }
        if (dis > 2)
        {
            rb.AddForce(dir* 2);
        }
	}
}
