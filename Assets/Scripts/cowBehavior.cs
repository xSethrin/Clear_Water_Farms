using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cowBehavior : MonoBehaviour{
    public Sprite noCow, cowNotFed, cowFed;
    public bool hasCow, wasFed, hasMilk;
    //temp int for testing
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }
    
    void OnMouseDown(){
        if(hasCow){
           if(!(wasFed) && JackObject.currentTool == "water"){//need to change from water to fooder
               GetComponent<SpriteRenderer>().sprite = cowFed;
               wasFed = true;
           }
           if(hasMilk && JackObject.currentTool == "hand"){
               Debug.Log("Got Milk!");
               hasMilk = false;
           }
        }
    }
    public void UpdateSprite(){
        GetComponent<SpriteRenderer>().sprite = cowNotFed;
    }
}
