using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Town : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "Cross_Roads")
        {
            player.position = new Vector2(-1.176987f, 0.4883403f);

        }
        else if (prevScene == "Town")
        {
            player.position = new Vector2(10.06f, -49.03f);

        }
        else if (prevScene == "Farm")
        {
            player.position = new Vector2(42.49f, -49.96f);

        }
        else if (prevScene == "Blacksmith_Store_Interrior")
        {
            player.position = new Vector2(-23.93f, 2.36f);

        }
        else if (prevScene == "Plant_Store_Interrior")
        {
            player.position = new Vector2(-11.73f, 23.21f);

        }
        else if (prevScene == "Animal_Store_Interrior")
        {
            player.position = new Vector2(-23.93f, 14.35f);

        }


    }

}

