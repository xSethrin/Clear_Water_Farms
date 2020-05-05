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
    }

}

