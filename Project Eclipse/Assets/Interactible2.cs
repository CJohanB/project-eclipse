using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Interactible2 : MonoBehaviour {

    public Effect effect = new Effect();

    bool incontact = false;
    bool itemUsed = false;

    GameObject GameMaster;
    GameObject Player;

    public int speedBoost;
    public int jumpBost;
    public float timeLimit;

    public void Start()
    {

        effect.speedBoost += speedBoost;
        effect.jumpBost += jumpBost;
        effect.timeLimit += timeLimit;
        GameMaster = GameObject.FindGameObjectWithTag("GameMaster");
        Player = GameObject.FindGameObjectWithTag("Player");


    }

    private void Update()
    {
       

        if (incontact == true && itemUsed == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                itemUsed = true;
                GameMaster.GetComponent<cheackEffects>().Cheack(effect);
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
