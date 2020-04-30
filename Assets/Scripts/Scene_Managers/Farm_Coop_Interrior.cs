using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm_Coop_Interrior : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "Farm")
        {
            player.position = new Vector2(0f, 4.143f);

        }
    }

}

