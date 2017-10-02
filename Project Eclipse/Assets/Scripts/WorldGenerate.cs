using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerate : MonoBehaviour {

    
    public float width;
    public float heightMultiplier;
    public int heigtAddition;

    public float smoothness;

    public float seed;


    public GameObject block;
    public GameObject startBlock;

	void Start ()
    {
        Generate();
        seed = Random.Range(-10000f, 10000f);
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
            Debug.Log(h);
            for (int j = 0; j < h; j++)
            {
                GameObject newBlock = Instantiate(block, new Vector3(i, j), Quaternion.identity);
                newBlock.transform.parent = transform;

            }
        }

    }

    
}
