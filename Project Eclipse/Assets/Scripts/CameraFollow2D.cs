using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2D : MonoBehaviour {

    public GameObject player; //Referens till spelaren.

    public Vector3 offset; //En vector 3 som är avståndet elelr offesten som kameren skall ha till spelaren.

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void LateUpdate()
    {
        transform.position = player.transform.position + offset; //Sätter kamerans position till spelarens + offesten
    }
}
