using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMove))]
public class PlayerController : MonoBehaviour {

    private PlayerMove playerMove;
    private bool jump;

    void Awake()
    {
        playerMove = GetComponent<PlayerMove>();
    }

	// Use this for initialization
	void Update () {

        jump = Input.GetKeyDown(KeyCode.Space);
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float horizontal = Input.GetAxis("Horizontal");

        playerMove.Move(horizontal, jump);
	}
}
