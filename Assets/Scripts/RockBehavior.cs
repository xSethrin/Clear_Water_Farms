using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBehavior : MonoBehaviour{
    
    public Sprite rock, noRock;
    public int timesHit = 0; 
    public bool isBig, notBroken = true;

    void OnMouseDown(){     
        if(JackObject.currentTool == "hammer" && notBroken && JackObject.stam > 0){
            if(isBig){
                if(timesHit >= 5){
                    GetComponent<SpriteRenderer>().sprite = noRock;
                    JackObject.ore+= 3;
                    JackObject.stam = JackObject.stam - (5 - JackObject.hammer);
                    notBroken = false;
                    GetComponent<BoxCollider2D>().enabled = false;
                }
                else{
                    timesHit++;
                    JackObject.stam = JackObject.stam - (5 - JackObject.hammer);
                }
            }
            else{
                if(timesHit >= 2){
                    GetComponent<SpriteRenderer>().sprite = noRock;
                    JackObject.ore+= 1;
                    JackObject.stam = JackObject.stam - (5 - JackObject.hammer);
                    notBroken = false;
                    GetComponent<BoxCollider2D>().enabled = false;
                }
                else{ 
                    timesHit++;
                    JackObject.stam = JackObject.stam - (5 - JackObject.hammer);
                }
            }
        }
    }

    //not needed?
    public void ResetRock(){
        notBroken = true;
        GetComponent<SpriteRenderer>().sprite = rock;
        timesHit = 0;
    }
}
