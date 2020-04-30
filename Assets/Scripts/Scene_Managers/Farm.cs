using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "Farm_House_Interrior")
        {
            player.position = new Vector2(26.44f, -45f);

        }
        else if (prevScene == "Cross_Roads")
        {
            player.position = new Vector2(-10.84f, -36.28f);

        }
        else if (prevScene == "Farm_Barn_Interrior")
        {
            player.position = new Vector2(-20.53f, -10.24f);

        }
        else if (prevScene == "Farm_Coop_Interrior")
        {
            player.position = new Vector2(7.56f, -1.31f);

        }

    }
}