using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* This class acts as a way to hold data for cows
* It also defines their behavior
*/
public class CowBehavior : MonoBehaviour{
    public Sprite noCow, cowNotFed, cowFed;//sprites for cows
    public bool hasCow, wasFed, hasMilk;//booleans for cow data

    /**
    * This method is used to determine what happens on click of the cow objects
    *
    */
    void OnMouseDown(){
        if(hasCow){//only do stuff if there is a cow
           if(!(wasFed) && JackObject.currentTool == "water"){//if statment to feed cow
               GetComponent<SpriteRenderer>().sprite = cowFed;//update sprite
               wasFed = true;
           }
           if(hasMilk && JackObject.currentTool == "hand"){//if statment to milk cow
                //Adding to inventory
                bool flag = true;
                for (int i = 0; i < JackObject.slots.Count; i++) {
                    if (JackObject.slots[i].produceName == "milk") {
                        flag = false;
                        JackObject.slots[i].quantity++;
                        break;
                    }
                }
                if (flag) {
                    JackObject.slots.Add(new Produce("milk", 150, 1));
                }
                hasMilk = false;
           }
        }
    }

    /**
    * This is a helper methiod to update sprite
    * It is used by other classes
    */
    public void UpdateSprite(){
        if(hasCow && !(wasFed)){//updates if has cow
            GetComponent<SpriteRenderer>().sprite = cowNotFed;
        }
        else if(hasCow && wasFed){
            GetComponent<SpriteRenderer>().sprite = cowFed;
        }
        else{//update if there is no cow
            GetComponent<SpriteRenderer>().sprite = noCow;
        }

    }
}