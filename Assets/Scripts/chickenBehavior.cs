using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* This class holds the data for Chicken Game Objects
*
*/
public class ChickenBehavior : MonoBehaviour{
    public Sprite noChicken, notFed, fed;//sprites for chickens
    public bool hasChicken = false, wasFed = false, hasEgg = false;//chicken data

    /**
    * This method is for when the chickens are clicked on.  Updates their data.
    *
    */
    void OnMouseDown(){
        if(hasChicken){//cklicking on the game object does nothing unl
            if(!(wasFed) && JackObject.currentTool == "water"){//this makes sure the chicken has not been fed yet and that the player has the correct item
                wasFed = true;
                GetComponent<SpriteRenderer>().sprite = fed;//updates sprite
            }
            if(hasEgg && JackObject.currentTool == "hand"){//this checks if the chicken laid an egg and gives one tp the player if true
                Debug.Log("Got Egg!");
                hasEgg = false;
            }
        }
    }

    /**
    * This method is a helper method for other classes.  It updates sprites as needed
    *
    */
    public void UpdateSprite(){
        if(hasChicken){//updates sprite if there is a chicken
            GetComponent<SpriteRenderer>().sprite = notFed;
        }
        else{//updates sprite if there is no chicken
            GetComponent<SpriteRenderer>().sprite = noChicken;
        }
    }

}
