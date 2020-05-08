using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeBehavior : MonoBehaviour{

    public Sprite tree, noTree;
    public int timesHit = 0; 
    public bool notChopped = true, isBig;


    void OnMouseDown(){
        //GameObject [] players = GameObject.FindGameObjectsWithTag("Player");//finds the player object
        //JackObject jack = players[0].GetComponent<JackObject>();//gets player data
        if(JackObject.currentTool == "axe"  && notChopped){
            if(isBig){
                if(timesHit >= 5){
                    GetComponent<SpriteRenderer>().sprite = noTree;
                    JackObject.lumber+= 3;
                    notChopped = false;
                }
                else{
                    timesHit++;
                }
            }
            else{
                if(timesHit >= 3){
                    GetComponent<SpriteRenderer>().sprite = noTree;
                    JackObject.lumber+= 1;
                    notChopped = false;
                }
                else{
                    timesHit++;
                }
            }
          
        }
    }
    
    public void ResetTree(){
        notChopped = true;
        GetComponent<SpriteRenderer>().sprite = tree;
        timesHit = 0;
    }

}
