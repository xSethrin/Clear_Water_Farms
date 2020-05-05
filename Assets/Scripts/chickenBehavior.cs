using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* This class holds the data for Chicken Game Objects
*
*/
public class ChickenBehavior : MonoBehaviour{
    public Sprite noChicken, notFed, fed, egg;//sprites for chickens
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
                //Adding to inventory
                bool flag = true;
                for (int i = 0; i < JackObject.slots.Count; i++) {
                    if(JackObject.slots[i].nameOf == "egg") {
                        flag = false;
                        JackObject.slots[i].quantity++;
                        break;
                    }
                }
                if (flag) {
                    JackObject.slots.Add(new Produce("egg", 100, 1, egg));
                }

                    //if (other.CompareTag("Player")) {
                    //    for (int i = 0; i < inventory.slots.Length; i++) {
                    //        //if()
                    //        //checking each slot to see if there is a free space
                    //        if (inventory.isFull[i] == false) {
                    //            //Item can be added
                    //            inventory.isFull[i] = true;
                    //            //button to be able to use object in slot
                    //            Instantiate(itemButton, inventory.slots[i].transform, false);
                    //            Destroy(gameObject);//removes object from scene
                    //            Debug.Log("Item has been picked up");
                    //            break;
                    //        }
                    //    }
                    //}
                }
                Debug.Log("Got Egg!");
                hasEgg = false;
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
