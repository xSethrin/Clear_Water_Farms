using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* This class updates data for the start of each day
*
*/
public class NewDayScript : MonoBehaviour{

    /**
    * This method updates data for the start of each day
    * It is ran when the player goes to sleep (clicks on the bed)
    */
    void OnMouseDown(){
        GameObject [] players = GameObject.FindGameObjectsWithTag("Player");//finds the player object
        JackObject jack = players[0].GetComponent<JackObject>();//gets player data
        jack.stam = 100;//resets stamina
        //Debug.Log("Reset Jack's Stamina");
        GameObject [] plants = GameObject.FindGameObjectsWithTag("Plant");//finds all the plants
        GameObject [] cows = GameObject.FindGameObjectsWithTag("Cow");//finds all the cows
        GameObject [] chickens = GameObject.FindGameObjectsWithTag("Chicken");//finds all the chickens
        foreach(GameObject plant in plants){//loops through all the plants
            PlantBehavior plantData = plant.GetComponent<PlantBehavior>();///gets plant data
            if(plantData.timesWatered == 3){//if plant was watered 3 times it is ready to grow to the next stage
                plantData.currentStage++;
                plantData.UpdateSprite(plantData.currentStage);//update sprite
                plantData.timesWatered = 0;//resets times watered
            }
            else{
                plantData.UpdateSprite(plantData.currentStage);//updates sprite to unwatered
            }
            plantData.isWatered = false;//sets is watered to false for each new day
        }
        foreach(GameObject cow in cows){//loops through the cows
            CowBehavior cowData = cow.GetComponent<CowBehavior>();//grab cow data
            if(cowData.wasFed){//checks if the cow was fed so the cow will make milk.  yummy
                cowData.hasMilk = true;
            }
            else{//if cow was not fed no milky for you =(
                cowData.hasMilk = false;
            }
            cowData.wasFed = false;//restes to false each day
            cowData.UpdateSprite();//updates sprite to not be fed
        }
        foreach(GameObject chicken in chickens){//loops through each chicken
            ChickenBehavior chickenData = chicken.GetComponent<ChickenBehavior>();//gets chicken data
            if(chickenData.wasFed){//checks if the cock was fed so you get your eggs
                chickenData.hasEgg = true;
            }
            else{//no feedy no eggies 
                chickenData.hasEgg = false;
            }
           chickenData.wasFed = false;//resets was fed every day
           chickenData.UpdateSprite();//changes sprite to that of the hungry chickie
        }
        Debug.Log("Jack Stamina: " + jack.stam);
        SaveSystem save = new SaveSystem();//creates a save object
        save.SaveGame(new GameData(players[0], cows, chickens, plants));//saves your game
    }
}
