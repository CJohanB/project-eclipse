using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class WorldGenerate : MonoBehaviour {

    
    public float width = 2000;
    public float heightMultiplier;
    public int heigtAddition;
    public float doorLocation;

    public float smoothness;

    public float seed;

    public GameObject topBlock;
    public GameObject block;
    public GameObject startBlock;
    public GameObject door; 
    
	void Start ()
    {
       
        seed = Random.Range(-10000f, 10000f);
        doorLocation = width - 10f;
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
                if(j == h - 1 && i == doorLocation)
                {
                    Debug.Log("Instantiated door at: x = " + i);
                    Instantiate (door, new Vector3(i , j + 1.5f), Quaternion.identity);
                }

                if (j == h - 1)
                {
                    GameObject newBlock = Instantiate(topBlock, new Vector3(i, j), Quaternion.identity);
                    newBlock.transform.parent = transform;
                }
                else
                {
                    GameObject newBlock = Instantiate(block, new Vector3(i, j), Quaternion.identity);
                    newBlock.transform.parent = transform; 
                }

            }
        }

        Instantiate(startBlock, new Vector3(width + 1.5f, 4.5f), Quaternion.identity);

        AstarPath.active.Scan();
    }

    
}
