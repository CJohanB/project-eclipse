using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerate : MonoBehaviour {

    
    public int width;
    public int heigt = 2;

    public GameObject block;

	void Start ()
    {
        Generate();
    }
	
	
    //En funktion som genererar världen.
    void Generate()
    {
        //Loopar igenom bredden.
        for (int i = 0; i < width; i++)
        {
            //Bestämmer en lokal variabel, "heigt2", som är världens höjd. Heigt2 blir ett värde mellan "heigt" och heigt +4.
            int heigt2 = Random.Range(heigt, heigt + 4);
            for (int j = 0; j < heigt2; j++)
            {
                Instantiate(block, new Vector3(i, j), Quaternion.identity);
            }
        }

    }
}
