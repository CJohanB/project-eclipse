using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class Tilling : MonoBehaviour {

    public int offsetX = 2;
    public int buddyCount = 0;
    public bool hasARightBuddy = false;
    public bool hasALeftBuddy = false;
    public bool stoppSpawning;

    public bool reverseScale = false;

    private float spriteWith = 0f;
    private Camera cam;
    private Transform myTransfrom;
    public GameObject exit;
    public Transform[] tiles;
   


    void Awake ()
    {
        cam = Camera.main;
        myTransfrom = transform; 

    }


    // Use this for initialization
    void Start () {
        SpriteRenderer sRenderer = GetComponent<SpriteRenderer>();
        spriteWith = sRenderer.sprite.bounds.size.x * 100;
        Debug.Log(spriteWith);
		
	}
	
	// Update is called once per frame
	void Update () {
        if (hasALeftBuddy == false && stoppSpawning == false || hasARightBuddy == false && stoppSpawning == false)
        {
            float camHorizontalExtend = cam.orthographicSize * Screen.width / Screen.height;

            float edgeVisiblePositionRight = (myTransfrom.position.x + spriteWith / 2) - camHorizontalExtend;
            float edgeVisiblePositionLeft = (myTransfrom.position.x - spriteWith / 2) + camHorizontalExtend;

            if (cam.transform.position.x >= edgeVisiblePositionRight - offsetX && hasARightBuddy == false)
            {
                buddyCount += 1;
                MakeNewBuddy(1);
                hasARightBuddy = true;
            
            }
            else if (cam.transform.position.x <= edgeVisiblePositionLeft + offsetX && hasALeftBuddy == false)
            {

                MakeNewBuddy(-1);
                hasALeftBuddy = true;
           
            }
        }
	}

    void MakeNewBuddy (int rightOrLeft)
    {
        Vector3 newPosition = new Vector3 (myTransfrom.position.x + spriteWith * rightOrLeft, myTransfrom.transform.position.y, myTransfrom.position.z);
        Transform newBuddy = Instantiate (myTransfrom, newPosition, myTransfrom.rotation) as Transform;

  
        Vector3 exitPosition = new Vector3(myTransfrom.position.x + spriteWith * rightOrLeft, myTransfrom.transform.position.y + 20, myTransfrom.position.z);
        if (buddyCount == 5)
        {
            Instantiate(exit, exitPosition, myTransfrom.rotation);
            

        }

   

        if (reverseScale == true)
        {
            newBuddy.localScale = new Vector3(newBuddy.localScale.x * -1, newBuddy.localScale.y, newBuddy.localScale.z);
        }

        newBuddy.parent = myTransfrom.parent;
        if (rightOrLeft > 0)
        {
            newBuddy.GetComponent<Tilling>().hasALeftBuddy = true;
        }
        else
        {
            newBuddy.GetComponent<Tilling>().hasARightBuddy = true;
        }
    }
}
