using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheackEffects : MonoBehaviour {

    public GameObject player;

    public List<Effect> effects = new List<Effect>();

    public void Cheack(Effect newEffect)
    {

        effects.Add(newEffect);
   
    }

    public void DoTheThings()
    {
        
            foreach (Effect e in effects)
            {
                if (e.hasBeenActivated != true)
                {
                    player.GetComponent<PlayerMove>().maxSpeed += e.speedBoost;
                    player.GetComponent<PlayerMove>().jumpForce += e.jumpBost;
                    e.hasBeenActivated = true;
                }
            }
        
       
    }

    void Update ()
    {
        //Debug.Log(effects.Count);
        if (effects.Count != 0)
            DoTheThings();
        
        foreach (Effect e in effects)
        {
            e.timeLimit -= Time.deltaTime;

            if (e.timeLimit <= 0)
            {
                Debug.Log("removing effect");
                RemoveEffect(e);
                effects.Remove(e);

            }
        }
    }


    private void RemoveEffect(Effect e)
    {
        player.GetComponent<PlayerMove>().maxSpeed -= e.speedBoost;
        player.GetComponent<PlayerMove>().jumpForce -= e.jumpBost;
    }
}
