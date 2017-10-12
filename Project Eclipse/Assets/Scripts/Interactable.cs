using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour{

    [SerializeField] private int itemID;

    [SerializeField] private int itemInProg;

    bool incontact = false;

     bool itemUsed = false;

    GameObject GameMaster;

    private void Update()
    {
        GameMaster = GameObject.FindGameObjectWithTag("GameMaster");


        if (incontact == true && itemUsed == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                itemInProg = itemID;
                itemUsed = true;
                GameMaster.GetComponent<ChecksID>().indentifiID = itemInProg;

            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        incontact = true;
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        incontact = false;
    }


}
