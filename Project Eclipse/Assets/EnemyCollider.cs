using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour {

    [SerializeField] private float ParantHealth;

    [SerializeField] GameObject DangerZone;

    [SerializeField] bool DamageAble;

    [Space]

    public GameObject GameMaster;

	// Use this for initialization
	void Start () {

        ParantHealth = GetComponentInParent<EnemyStats>().Health;
        DangerZone = GameObject.FindGameObjectWithTag("DangerZone");
        GameMaster = GameObject.FindGameObjectWithTag("GameMaster");
	}
	
	// Update is called once per frame
	void Update () {

        if (DamageAble && Input.GetKeyDown(KeyCode.K))
        {
            GetComponentInParent<EnemyStats>().Health -= GameMaster.GetComponent<PlayerThings>().DamangePlayerDo;
        }

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "DangerZone")
        {
            DamageAble = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DangerZone")
        {
            DamageAble = false;
        }
    }

}
