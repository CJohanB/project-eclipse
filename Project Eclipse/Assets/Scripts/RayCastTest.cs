using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTest : MonoBehaviour {


    public GameObject target;

	// Update is called once per frame
	void FixedUpdate () {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 100);

        Debug.DrawLine(transform.position, hit.transform.position);
	}
}
