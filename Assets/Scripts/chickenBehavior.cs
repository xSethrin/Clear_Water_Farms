using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenBehavior : MonoBehaviour{
    public Sprite noChicken, notFed, fed;
    public bool hasChicken = false, wasFed = false, hasEgg = false;
    int count;//temp int for testing
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }
    
    void OnMouseDown(){
        if(hasChicken){
            if(!(wasFed) && JackObject.currentTool == "water"){//change to feed
                wasFed = true;
                GetComponent<SpriteRenderer>().sprite = fed;
            }
            if(hasEgg && JackObject.currentTool == "hand"){
                Debug.Log("Got Egg!");
                hasEgg = false;
            }
        }
    }

    public void UpdateSprite(){
        GetComponent<SpriteRenderer>().sprite = notFed;
    }

}
