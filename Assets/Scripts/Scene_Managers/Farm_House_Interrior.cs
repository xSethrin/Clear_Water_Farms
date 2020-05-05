using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm_House_Interrior : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "Farm")
        {
            player.position = new Vector2(9.47f, -31.62f);

        }
    }

}
