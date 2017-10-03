using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerate : MonoBehaviour {

    
    public float width;
    public float heightMultiplier;
    public int heigtAddition;
    public float doorLocation;

    public float smoothness;

    public float seed;

    
    public GameObject block;
    public GameObject startBlock;
    public GameObject door; 
    
	void Start ()
    {
       
        seed = Random.Range(-10000f, 10000f);
        doorLocation = width - 10;
        Generate();
    }
	
	
    //En funktion som genererar världen.
    void Generate()
    {
        
        Instantiate(startBlock, new Vector3(-2.5f, 4.5f), Quaternion.identity);
        //Loopar igenom bredden.
        for (int i = 0; i < width; i++)
        {
            //Bestämmer en lokal variabel, "heigt2", som är världens höjd. Heigt2 blir ett värde mellan "heigt" och heigt +4.
            int h = Mathf.RoundToInt(Mathf.PerlinNoise(seed, i / smoothness) * heightMultiplier) + heigtAddition;
            for (int j = 0; j < h; j++)
            {
                if(j == h - 1 && i == 40)
                {
                    Debug.Log("Instantiated door at: x = " + i);
                    Instantiate (door, new Vector3(i , j + 1.5f), Quaternion.identity);
                }
                GameObject newBlock = Instantiate(block, new Vector3(i, j), Quaternion.identity);
                newBlock.transform.parent = transform;

            }
        }

    }

    
}
