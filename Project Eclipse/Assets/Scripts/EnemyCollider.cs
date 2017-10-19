using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour {

    [SerializeField] private float ParantHealth;

    [SerializeField] GameObject DangerZone;

    [SerializeField] bool DamageAble;

	// Use this for initialization
	void Start () {

        ParantHealth = GetComponentInParent<EnemyStats>().Health;
        DangerZone = GameObject.FindGameObjectWithTag("DangerZone");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (DangerZone)
        {
            DamageAble = true;
        }

    }

}
