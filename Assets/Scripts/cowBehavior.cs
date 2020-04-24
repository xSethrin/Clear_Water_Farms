using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cowBehavior : MonoBehaviour{
    public Sprite noCow, cowNotFed, cowFed;
    public bool hasCow, wasFed, hasMilk;
    int count;//temp int for testing
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }
    
    void OnMouseDown(){
        if(count == 0){
            Debug.Log("bought a cow!");
            count++;
            GetComponent<SpriteRenderer>().sprite = cowNotFed;
        }
        else if(count == 1){
            Debug.Log("Fed cow!");
            GetComponent<SpriteRenderer>().sprite = cowFed;
        }
    }
}
