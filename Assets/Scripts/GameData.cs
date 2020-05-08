using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* This class gatheres all data needed to be saved and store it in a single object
* That object is then saved to an external file in binary form
*/
[System.Serializable]//this allows the object to be converted into a binary form and saved to a file
public class GameData {

    public int [] playerData = new int [8];//int array for Player data
    //TODO add player inventory
    public int [] hasCow;//int array for cow bool
    public int [] hasMilk;//int array for milk bool
    public int [] hasChicken;//int array for chicken bool
    public int [] hasEgg;//int array for egg bool
    public int [] currentStage;
    public int [] timesWatered;
    public int [] isTilled;
    public int [] hasPlant;

    /** 
    * This is a constructor for the GameData object 
    * This constructor is used when we need to grab data from the game objects to store into the game data
    * it requires GameObject player, GameObject [] cows, GameObject [] chickens and GameObject [] plants
    * each objected will be parsed and data from these objects that needs to be saved will be stored
    */
    public GameData(GameObject [] cows, GameObject [] chickens, GameObject [] plants){
        //JackObject jack = player.GetComponent<JackObject>();//grabs the players data
        //these lines set the players data to the array         
        playerData[0] = JackObject.gold;
        playerData[1] = JackObject.water;   
        playerData[2] = JackObject.hoe;
        playerData[3] = JackObject.sickle;
        playerData[4] = JackObject.hammer;
        playerData[5] = JackObject.axe;
        playerData[6] = JackObject.lumber;
        playerData[7] = JackObject.ore;
        hasCow = new int [cows.Length];//instantiates hasCow array 
        hasMilk = new int [cows.Length];//instantiate hasMilk array
        for(int i = 0; i < cows.Length; i++){//loops through the cows
            CowBehavior cow = cows[i].GetComponent<CowBehavior>();//grabs cow data
            if(cow.hasCow){//checks if has cow
                hasCow[i] = 1;
            }
            else{
                hasCow[i] = 0;
            }
            if(cow.hasMilk){//check if has milk
                hasMilk[i] = 1;
            }
            else{
                hasMilk[i] = 0;
            }
        }
        hasChicken = new int [chickens.Length];//instantiate hasChicken array
        hasEgg = new int [chickens.Length];//instantiate hasEgg array
        for(int i = 0; i < chickens.Length; i++){//this loops through the chickens
             ChickenBehavior chicken = chickens[i].GetComponent<ChickenBehavior>();//grabs chicken data
             if(chicken.hasChicken){//checks if has chicken
                 hasChicken[i] = 1;
             }
             else{
                 hasChicken[i] = 0;
             }
             if(chicken.hasEgg){//checks if has egg
                 hasEgg[i] = 1;
             }
             else{
                 hasEgg[i] = 0;
             }
        }
        currentStage = new int [plants.Length];//instantiate currentStage array
        timesWatered = new int [plants.Length];//instantiate timesWatered array
        isTilled = new int [plants.Length];//instantiate isTilled array
        hasPlant = new int [plants.Length];//instantiate hasPlant array
        for(int i = 0; i < plants.Length; i++){//loops through plant arrays
            PlantBehavior plant = plants[i].GetComponent<PlantBehavior>();//grabs plant data
            currentStage[i] = plant.currentStage;//sets current stage for plant
            timesWatered[i] = plant.timesWatered;//sets times watered for plant
            if(plant.isTilled){//sets value for tilled
                isTilled[i] = 1;
            }
            else{
                isTilled[i] = 0;
            }
            if(plant.hasPlant){//sets value for hasplant
                hasPlant[i] = 1;
            }
            else{
                hasPlant[i] = 0;
            }
        }
    } 

    /**
    * This constructor is used to load data
    *
    */
    public GameData(int [] playerData, int [] hasCow, int [] hasMilk, int [] hasChicken,int [] hasEgg, int [] currentStage, int [] timesWatered, int [] isTilled, int [] hasPlant){
        this.playerData = playerData;
        this.hasCow = hasCow;
        this.hasMilk = hasMilk;
        this.hasChicken = hasChicken;
        this.hasEgg = hasEgg;
        this.currentStage = currentStage;
        this.timesWatered =timesWatered;
        this.isTilled = isTilled;
        this.hasPlant = hasPlant;
    }
}

