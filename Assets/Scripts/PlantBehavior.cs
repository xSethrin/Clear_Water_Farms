using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBehavior : MonoBehaviour{

    public Sprite untilled, tilled, stage1, stage1W, stage2, stage2W, stage3, harvest;//each of these is used to update the sprite
    public int timesWatered = 0, currentStage = 0;//timesWatered is used to detemer how many times the plant was watered.  this value will be used to check plants stage as well.
    public bool isWatered = false, isTilled = false, hasPlant = false;//isWatered checks if the plant was watered.  This will be used when player goes to sleep to properly update plant
    
    /**
    * This method handles the event where the field is clicked on. 
    * changes depend on plant state and equipted tool 
    */
    void OnMouseDown(){

        if(JackObject.currentTool == "hoe" && !(isTilled) && !(hasPlant)){//if land is untilled, does not have plant, and current tool is hoe
            //Debug.Log("Field was tilled!");
            GetComponent<SpriteRenderer>().sprite = tilled;//update sprite
            isTilled = true;//set isTilled to true
            JackObject.stam = JackObject.stam - (5 - JackObject.hoe);//decreases stamina by 5 - tool level
        }
        //TODO switch to seeds being held
        else if(JackObject.currentTool == "seeds" && isTilled && !(hasPlant) && JackObject.seeds < 0){//if current tool is seeds, land is tilled, and does not have a plant
            //Debug.Log("Seed planted! at stage 1");
            GetComponent<SpriteRenderer>().sprite = stage1;//update sprite to stage 1
            currentStage = 1;//set current sage to 1
            hasPlant = true;//set hasPlant to true
            JackObject.seeds--;
        }
        else if (JackObject.currentTool == "water" && !(isWatered) && hasPlant && JackObject.waterAmount < 0){//if current tool is water, and tile is unwattered, and tile has plant
            if(currentStage == 1){//if current stage is stage 1
                //Debug.Log("Stage 1 watered");
                GetComponent<SpriteRenderer>().sprite = stage1W;//update sprite
            }
            else if(currentStage == 2){//if plat is ate stage 2
                //Debug.Log("Stage 2 watered");
                GetComponent<SpriteRenderer>().sprite = stage2W;//update sprite     
            }
            timesWatered++;//increment times wattered
            isWatered = true;//set is watered to true
            JackObject.waterAmount--;//decrease water in watering can
            JackObject.stam = JackObject.stam - (5 - JackObject.water);//decrease stam by 5- tool level
        }
        else if(JackObject.currentTool == "hand" && currentStage == 3){//if plant is ready to be picked and jacks hands are empty
            //Debug.Log("picking plant");
            GetComponent<SpriteRenderer>().sprite = tilled;//update sprite
            hasPlant = false;//set hasplant to false
            isWatered = false;// set is watered to false
            isTilled = true;// set is tilled to true
            currentStage = 0;//reset current stage
            timesWatered = 0;//reset times watered
        }
         else if(JackObject.currentTool == "hammer" && !(hasPlant) && isTilled){//ifcurrent tool is hammer and there is no plant, and the tile is tilled
            //Debug.Log("untilling land");
            GetComponent<SpriteRenderer>().sprite = untilled;//update sprite
            isTilled = false;//set isTilled to false
            isWatered = false;//set isWatered to false
            currentStage = 0;//set current stage to 0
            timesWatered = 0;//set times watered to 0
            JackObject.stam = JackObject.stam - (5 - JackObject.hammer);
        }
         else if(JackObject.currentTool == "sickle" && hasPlant){//if there is a plant and the sickle is the current tool
            //Debug.Log("cutting down plant");
            GetComponent<SpriteRenderer>().sprite = tilled;//update sprite
            currentStage = 0;//set current stage to 0
            timesWatered = 0;//restes times watered
            isWatered = false;//set times watered to 0
            hasPlant = false;//set hasPlant to false
            JackObject.stam = JackObject.stam - (5 - JackObject.sickle);

        }
    }

    /**
    * This method is used to update the sprite each day.  
    *
    */
    public void UpdateSprite(int plantStage){
        if(plantStage == 1){//if the stage is at stage 1
            GetComponent<SpriteRenderer>().sprite = stage1;//update sprite
        }
        else if(plantStage == 2){//if the stage is at stage 2
            GetComponent<SpriteRenderer>().sprite = stage2;//update sprite
        }
        else if (plantStage == 3){//if the stage is at stage 3
            GetComponent<SpriteRenderer>().sprite = stage3;//update sprite
        }
    }
    
}