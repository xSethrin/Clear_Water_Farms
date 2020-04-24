using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fieldBehavior : MonoBehaviour{

    public Sprite untilled, tilled, stage1, stage1W, stage2, stage2W, stage3;//each of these is used to update the sprite
    public int timesWatered = 0, count = 0, currentStage = 0;//timesWatered is used to detemer how many times the plant was watered.  this value will be used to check plants stage as well.
    //count is a temp value for testing, will remove later
    public bool isWatered = false, isTilled = false, hasPlant = false;//isWatered checks if the plant was watered.  This will be used when player goes to sleep to properly update plant



    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }
    
    void OnMouseDown(){
        //TODO
        //we will not allow people to water tilled fields with no plant.
        //we will not allow people to plant in untilled soil
        //make sure to check these things in if statments

        if(JackObject.currentTool == "hoe" && !(isTilled)){//change to hoe equipted
            Debug.Log("Field was tilled!");
            GetComponent<SpriteRenderer>().sprite = tilled;
            isTilled = true;
        }
        else if(JackObject.currentTool == "hand" && isTilled){//need to set up a way to use seeds.
            Debug.Log("Seed planted! at stage 1");
            GetComponent<SpriteRenderer>().sprite = stage1;
            currentStage = 1;
            hasPlant = true;
        }
        else if (JackObject.currentTool == "water" && !(isWatered) && hasPlant){
            if(currentStage == 1){
                Debug.Log("Stage 1 watered");
                GetComponent<SpriteRenderer>().sprite = stage1W;
                timesWatered++;
            }
            else if(currentStage == 2){
                Debug.Log("Stage 2 watered");
                GetComponent<SpriteRenderer>().sprite = stage2W;
                timesWatered++;
            }
        }
        else if(JackObject.currentTool == "hand" && currentStage == 3){
            Debug.Log("picking plant");
            GetComponent<SpriteRenderer>().sprite = tilled;
        }
         else if(JackObject.currentTool == "hammer" && !(hasPlant)){
            Debug.Log("untilling land");
            GetComponent<SpriteRenderer>().sprite = untilled;
        }
         else if(JackObject.currentTool == "sickle" && hasPlant){
            Debug.Log("cutting down plant");
            GetComponent<SpriteRenderer>().sprite = tilled;
            hasPlant = false;
        }
        /**
         else if(count == 6){
            Debug.Log("harvested!");
            count = 0;
            GetComponent<SpriteRenderer>().sprite = tilled;
         }
         */
    }
    
}