using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* This class runs the load function.
* It takes the binary file and changes it back to primative data types
* This data is then put back into their game objects
*/
public class LoadGame : MonoBehaviour{

    /**
    *This method is run when the player clicks the load button
    *It loads in all data from the most recent save
    */
    void OnMouseDown(){
        SaveSystem save = new SaveSystem();//creates a save object
        GameData data = save.LoadGame();//creates a game data object
        int [] playerData = data.playerData;//int array for Player data
        int [] hasCow = data.hasCow;//int array for cow bool
        int [] hasMilk = data.hasMilk;//int array for milk bool
        int [] hasChicken = data.hasChicken;//int array for chicken bool
        int [] hasEgg = data.hasEgg;//int array for egg bool
        int [] currentStage = data.currentStage;
        int [] timesWatered = data.timesWatered;
        int [] isTilled = data.isTilled;
        int [] hasPlant = data.hasPlant;
        JackObject.stam = 100;//restes jacks stamina
        //GameObject [] plants = GameObject.FindGameObjectsWithTag("Plant");//gets the plant objects
        //GameObject [] cows = GameObject.FindGameObjectsWithTag("Cow");//gets the cow objects
        //GameObject [] chickens = GameObject.FindGameObjectsWithTag("Chicken");//gets the chicken objects
       // GameObject [] plants = GameObject.FindGameObjectsWithTag("Plant");//gets all plant objects
        //the following lines set all of jacks data back to what was saved
        JackObject.gold = playerData[0];
        JackObject.water = playerData[1];   
        JackObject.hoe = playerData[2];
        JackObject.sickle = playerData[3];
        JackObject.hammer = playerData[4];
        JackObject.axe = playerData[5];
        JackObject.lumber = playerData[6];
        JackObject.ore = playerData[7];
        //int i = 0;//variable for incrimenting through the cow, chicken, and plant objects
        for(int i = 0; i < 10; i ++){//loop through each cow object
            //CowBehavior cowData = cow.GetComponent<CowBehavior>();//grabs the cow behavior which holds cow data
            if(hasCow[i] == 1){//checks if has cow is true
                FarmData.hasCow[i] = true;//sets to true
            }
            else{
                FarmData.hasCow[i] = false;//set false
            }
            if(hasMilk[i] == 1){//checks if cow has milk
                FarmData.hasMilk[i] = true;//sets true
            }
            else{
                FarmData.hasMilk[i] = false;//sets false
            }
            FarmData.cowWasFed[i] = false;//wasFed set is always set to false. THIS IS NEEDED TO PREVENT BUGS IF PLAYER LOADS GAME WHILE PLAYING WITHOUT SAVING 1ST
            //cowData.UpdateSprite();//updates cow sprite
            //i++;
        }
        //i = 0;//resest i for chickens
        for(int i = 0; i < 10; i++){
            //ChickenBehavior chickenData = chicken.GetComponent<ChickenBehavior>();//grab chicken behavior
            if(hasChicken[i] == 1){//check if has chicken is true
                FarmData.hasChicken[i] = true;
            }
            else{
                FarmData.hasChicken[i] = false;
            }
            if(hasEgg[i] == 1){//check if has egg is true
                FarmData.hasEgg[i] = true;
            }
            else{
                FarmData.hasEgg[i] = false;
            }
            FarmData.chickenWasFed[i] = false;//always set to false, needed to prevent bugs
            //chickenData.UpdateSprite();//updates sprite
            //i++;
        }
        //i = 0;//restes i for plants
        for(int i = 0; i < 255; i++){
            //PlantBehavior plantData = plant.GetComponent<PlantBehavior>();
            FarmData.currentStage[i] = currentStage[i];//sets current stage for plant
            FarmData.timesWatered[i] = timesWatered[i];//sets times watered for plant
            if(isTilled[i] == 1){//sets value for tilled
                FarmData.isTilled[i] = true;
            }
            else{
                FarmData.isTilled[i] = false;
            }
            if(hasPlant[i] == 1){//sets value for hasplant
                FarmData.hasPlant[i] = true;
            }
            else{
                FarmData.hasPlant[i] = false;
            }
            FarmData.isWatered[i] = false;
            //plantData.UpdateSprite(currentStage[i]);
        }
    }
}
