using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cross_Roads : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "Forest")
        {
            player.position = new Vector2(26.06f, -34.82f);

        }
        else if (prevScene == "Town")
        {
            player.position = new Vector2(10.06f, -49.03f);

        }
        else if (prevScene == "Farm")
        {
            player.position = new Vector2(42.49f, -49.96f);

        }


    }

}
