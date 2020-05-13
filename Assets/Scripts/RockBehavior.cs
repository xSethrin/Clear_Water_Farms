using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBehavior : MonoBehaviour{
    
    public Sprite rock, noRock;
    public int timesHit = 0; 
    public bool isBig, notBroken = true;

    void OnMouseDown(){     
        if(JackObject.currentTool == "hammer" && notBroken){
            if(isBig){
                if(timesHit >= 5){
                    GetComponent<SpriteRenderer>().sprite = noRock;
                    JackObject.ore+= 3;
                    JackObject.stam = JackObject.stam - (5 - JackObject.hammer);
                    notBroken = false;
                }
                else{
                    timesHit++;
                }
            }
            else{
                if(timesHit >= 3){
                    GetComponent<SpriteRenderer>().sprite = noRock;
                    JackObject.ore+= 1;
                    JackObject.stam = JackObject.stam - (5 - JackObject.hammer);
                    notBroken = false;
                }
                else{ 
                    timesHit++;
                }
            }
        }
    }

    //not needed?
    public void ResetRock(){
        notBroken = true;
        GetComponent<SpriteRenderer>().sprite = rock;
        timesHit =0;
    }
}
