using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecksID : MonoBehaviour {

    public int indentifiID = 0;

    GameObject Player;

    GameObject GameMaster;

    float Time;

    float TempTime;

	// Use this for initialization
	void Start () {

        Player = GameObject.FindGameObjectWithTag("Player");

        GameMaster = GameObject.FindGameObjectWithTag("GameMaster");

	}
	
	// Update is called once per frame
	void Update () {


        if (indentifiID != 0)
        {


            if (indentifiID == 1)
            {
                Player.GetComponent<PlayerMove>().maxSpeed += 10;
                indentifiID = 0;
            }
            if (indentifiID == 2)
            {
                Player.GetComponent<PlayerMove>().jumpForce += 10;
                indentifiID = 0;
            }
            if (indentifiID == 3)
            {
                GameMaster.GetComponent<PlayerThings>().DamangePlayerDo += 0.5f;
                indentifiID = 0;
            }














        }

	}
}
