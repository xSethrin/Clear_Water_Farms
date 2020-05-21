using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* This class defines behavior for rock objects
*
*/
public class TreeBehavior : MonoBehaviour{

    public Sprite tree, noTree;
    public int timesHit = 0; 
    public bool notChopped = true, isBig, ableToChop;

    /**
    * This method acts as hitting the tree with your axe
    *
    */
    void OnMouseDown(){
        if(ableToChop){
            if(JackObject.currentTool == "axe"  && notChopped && JackObject.stam > 0){//checks if the axe is the current tool 
                if(isBig){//checks if the tree is big
                    if(timesHit >= 5){
                        GetComponent<SpriteRenderer>().sprite = noTree;
                        JackObject.lumber+= 3;//adds to lumber
                        notChopped = false;//set notchopped to false
                        JackObject.stam = JackObject.stam - (5 - JackObject.axe);
                    }
                    else{
                        timesHit++;//increase times hit
                    }
                }
                else{//checks if tree is hit
                    if(timesHit >= 3){
                        GetComponent<SpriteRenderer>().sprite = noTree;
                        JackObject.lumber+= 1;
                        notChopped = false;
                        JackObject.stam = JackObject.stam - (5 - JackObject.axe);

                    }
                    else{
                        timesHit++;
                    }
                }
            
            }
        }
    }
    
    //no longer need?
    public void ResetTree(){
        notChopped = true;
        GetComponent<SpriteRenderer>().sprite = tree;
        timesHit = 0;
    }

}
