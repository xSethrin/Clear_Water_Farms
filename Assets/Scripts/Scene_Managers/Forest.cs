using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forest : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "Cave")
        {
            player.position = new Vector2(7.6f, -21.39f);

        }
        else if (prevScene == "Cross_Roads")
        {
            player.position = new Vector2(28f, -45.52f);

        }

    }

}