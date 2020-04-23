using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldBuilderScript : MonoBehaviour{

    public Transform fieldObject; 

    //TODO
    //public feildBehavior [] field;//need to initiate as untilled and unwatered.

    // Start is called before the first frame update
    void Start(){
        //TODO
        //make if stament that checks saved data for field.  If it is there instead of making an empty field we can update it to the aved file then paint it.
        //this should be done every game day at the start of the day.
        //this should look for the isWatered.  If it iswatered update the stage and sprite before painting
        for(int xPos = -1 ; xPos < 14; xPos++){
            for(int yPos = -14; yPos > -23; yPos--){
                Instantiate (fieldObject, new Vector2(xPos, yPos), fieldObject.rotation);
            }
        }
    }

    // Update is called once per frame
    void Update(){
        
    }
}
