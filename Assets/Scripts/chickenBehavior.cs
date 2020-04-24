using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenBehavior : MonoBehaviour{
    public Sprite noChicken, notFed, fed;
    public bool hasChicken, wasFed, hasEgg;
    int count;//temp int for testing
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }
    
    void OnMouseDown(){
        if(count == 0){
            Debug.Log("bought a chicken!");
            count++;
            GetComponent<SpriteRenderer>().sprite = notFed;
        }
        else if(count == 1){
            Debug.Log("Fed chiecken!");
            GetComponent<SpriteRenderer>().sprite = fed;
        }
    }
}
