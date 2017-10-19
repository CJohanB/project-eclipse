using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour{

    [SerializeField] private int itemID;

    [SerializeField] private int itemInProg;

    bool incontact = false;

     bool itemUsed = false;

    GameObject GameMaster;

    GameObject Player;

    private void Update()
    {
        GameMaster = GameObject.FindGameObjectWithTag("GameMaster");
        Player = GameObject.FindGameObjectWithTag("Player");

        if (incontact == true && itemUsed == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                itemInProg = itemID;
                itemUsed = true;
                GameMaster.GetComponent<ChecksID>().indentifiID = itemInProg;
                Destroy(gameObject);
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            incontact = true;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            incontact = false;
        }
    }


}
