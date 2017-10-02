using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2D : MonoBehaviour {

    public GameObject player; //Referens till s

    public Vector3 offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
