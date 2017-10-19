using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour {

    private bool Alive = true;

    public float Health;


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
        if (Health <= 0)
        {
            Alive = false;
        }
        if (Alive == false)
        {
            Destroy(gameObject);
        }
	}
}
