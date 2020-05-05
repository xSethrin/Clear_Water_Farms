using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cave : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "Forest")
        {
            player.position = new Vector2(26.3f, -44.4f);

        }
    }

}
