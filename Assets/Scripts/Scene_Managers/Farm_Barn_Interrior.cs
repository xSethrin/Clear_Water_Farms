using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm_Barn_Interrior : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "Farm")
        {
            player.position = new Vector2(0f, 1.15f);

        }
        GameObject [] cows = GameObject.FindGameObjectsWithTag("Cow");//finds all the plants
        int i = 0;
        foreach(GameObject cow in cows){
            CowBehavior data = cow.GetComponent<CowBehavior>();
            if(FarmData.cowData == null){
                data.hasCow = false;
                data.wasFed = false;
                data.hasMilk = false;
            } 
            else{
                data.hasCow = FarmData.cowData[i].GetComponent<CowBehavior>().hasCow;
                data.wasFed = FarmData.cowData[i].GetComponent<CowBehavior>().wasFed;
                data.hasMilk = FarmData.cowData[i].GetComponent<CowBehavior>().hasMilk;
            }
            i++;
        }
    }

}

