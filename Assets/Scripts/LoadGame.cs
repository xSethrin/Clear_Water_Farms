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
        GameObject [] players = GameObject.FindGameObjectsWithTag("Player");//finds the player
        JackObject jack = players[0].GetComponent<JackObject>();//gets the JackObject component
        jack.stam = 100;//restes jacks stamina
        //GameObject [] plants = GameObject.FindGameObjectsWithTag("Plant");//gets the plant objects
        GameObject [] cows = GameObject.FindGameObjectsWithTag("Cow");//gets the cow objects
        GameObject [] chickens = GameObject.FindGameObjectsWithTag("Chicken");//gets the chicken objects
        GameObject [] plants = GameObject.FindGameObjectsWithTag("Plant");//gets all plant objects
        //the following lines set all of jacks data back to what was saved
        jack.gold = playerData[0];
        jack.water = playerData[1];   
        jack.hoe = playerData[2];
        jack.sickle = playerData[3];
        jack.hammer = playerData[4];
        jack.axe = playerData[5];
        jack.lumber = playerData[6];
        jack.ore = playerData[7];
        int i = 0;//variable for incrimenting through the cow, chicken, and plant objects
        foreach(GameObject cow in cows){//loop through each cow object
            CowBehavior cowData = cow.GetComponent<CowBehavior>();//grabs the cow behavior which holds cow data
            if(hasCow[i] == 1){//checks if has cow is true
                cowData.hasCow = true;//sets to true
            }
            else{
                cowData.hasCow = false;//set false
            }
            if(hasMilk[i] == 1){//checks if cow has milk
                cowData.hasMilk = true;//sets true
            }
            else{
                cowData.hasMilk = false;//sets false
            }
            cowData.wasFed = false;//wasFed set is always set to false. THIS IS NEEDED TO PREVENT BUGS IF PLAYER LOADS GAME WHILE PLAYING WITHOUT SAVING 1ST
            cowData.UpdateSprite();//updates cow sprite
            i++;
        }
        i = 0;//resest i for chickens
        foreach(GameObject chicken in chickens){
            ChickenBehavior chickenData = chicken.GetComponent<ChickenBehavior>();//grab chicken behavior
            if(hasChicken[i] == 1){//check if has chicken is true
                chickenData.hasChicken = true;
            }
            else{
                chickenData.hasChicken = false;
            }
            if(hasEgg[i] == 1){//check if has egg is true
                chickenData.hasEgg = true;
            }
            else{
                chickenData.hasEgg = false;
            }
            chickenData.wasFed = false;//always set to false, needed to prevent bugs
            chickenData.UpdateSprite();//updates sprite
            i++;
        }
        i = 0;//restes i for plants
        foreach(GameObject plant in plants){
            PlantBehavior plantData = plant.GetComponent<PlantBehavior>();
            plantData.currentStage = currentStage[i];//sets current stage for plant
            plantData.timesWatered = timesWatered[i];//sets times watered for plant
            if(isTilled[i] == 1){//sets value for tilled
                plantData.isTilled = true;
            }
            else{
                plantData.isTilled = false;
            }
            if(hasPlant[i] == 1){//sets value for hasplant
                plantData.hasPlant = true;
            }
            else{
                plantData.hasPlant = false;
            }
            plantData.isWatered = false;
            plantData.UpdateSprite(currentStage[i]);
        }
        //The following code is needed incase the player loads a game mid day without saving
        GameObject [] rocks = GameObject.FindGameObjectsWithTag("Rock");
        GameObject [] trees = GameObject.FindGameObjectsWithTag("Tree");
        foreach(GameObject rock in rocks){//grabs each rock in game world
            RockBehavior rockData = rock.GetComponent<RockBehavior>();//gets rock behavior component
            rockData.ResetRock();//resets each rock
        }
        foreach(GameObject tree in trees){//grabs each tree in game world
            TreeBehavior treeData = tree.GetComponent<TreeBehavior>();//get tree data
            treeData.ResetTree();//resets each tree
        }
    }
}
