using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant_Store_Interrior : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "Town")
        {
            player.position = new Vector2(-5.89f, -3.94f);

        }
        

    }

}
