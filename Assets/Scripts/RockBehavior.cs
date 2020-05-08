using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBehavior : MonoBehaviour{
    
    public Sprite rock, noRock;
    public int timesHit = 0; 
    public bool isBig, notBroken = true;

    void OnMouseDown(){
        //GameObject [] players = GameObject.FindGameObjectsWithTag("Player");//finds the player object
        //JackObject jack = players[0].GetComponent<JackObject>();//gets player data        
        if(JackObject.currentTool == "hammer" && notBroken){
            if(isBig){
                if(timesHit >= 5){
                    GetComponent<SpriteRenderer>().sprite = noRock;
                    JackObject.ore+= 3;
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
                    notBroken = false;
                }
                else{ 
                    timesHit++;
                }
            }
        }
    }

    public void ResetRock(){
        notBroken = true;
        GetComponent<SpriteRenderer>().sprite = rock;
        timesHit =0;
    }
}
