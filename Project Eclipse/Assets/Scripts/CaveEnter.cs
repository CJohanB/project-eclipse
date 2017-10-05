using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CaveEnter : MonoBehaviour {

    public GameObject uiButton;
    public string caveLevel;
    bool enterdDoor = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (enterdDoor)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(caveLevel);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other )
    {
        if (other.tag == "Player")
        {
            enterdDoor = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            enterdDoor = false;
           // uiButton.SetActive(false); 
        }
    }
}
