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
        //GameObject [] players = GameObject.FindGameObjectsWithTag("Player");//finds the player object
        //JackObject jack = players[0].GetComponent<JackObject>();//gets player data
        JackObject.stam = 100;//resets stamina
        //Debug.Log("Reset Jack's Stamina");
        /**
        GameObject [] plants = GameObject.FindGameObjectsWithTag("Plant");//finds all the plants
        GameObject [] cows = GameObject.FindGameObjectsWithTag("Cow");//finds all the cows
        GameObject [] chickens = GameObject.FindGameObjectsWithTag("Chicken");//finds all the chickens
        GameObject [] rocks = GameObject.FindGameObjectsWithTag("Rock");
        GameObject [] trees = GameObject.FindGameObjectsWithTag("Tree");
        */
        for(int i = 0; i < 255; i++){//loops through all the plants
            if(FarmData.timesWatered[i] == 3){//if plant was watered 3 times it is ready to grow to the next stage
                FarmData.currentStage[i]++;
                //plantData.UpdateSprite();//update sprite
                FarmData.timesWatered[i] = 0;//resets times watered
            }
            /**
            else{
                plantData.UpdateSprite();//updates sprite to unwatered
            }
            */
            FarmData.isWatered[i] = false;//sets is watered to false for each new day
        }
        for(int i = 0; i < 10; i++){//loops through the cows
            //CowBehavior cowData = cow.GetComponent<CowBehavior>();//grab cow data
            if(FarmData.cowWasFed){//checks if the cow was fed so the cow will make milk.  yummy
                FarmData.hasMilk[i] = true;
            }
            else{//if cow was not fed no milky for you =(
                FarmData.hasMilk[i] = false;
            }
            FarmData.cowWasFed[i] = false;//restes to false each day
            //cowData.UpdateSprite();//updates sprite to not be fed
        }
        for(int i = 0; i < 10; i++){//loops through each chicken
            ChickenBehavior chicken//Data = chicken.GetComponent<ChickenBehavior>();//gets chicken data
            if(FarmData.wasFed[i]){//checks if the cock was fed so you get your eggs
                FarmData.hasEgg[i] = true;
            }
            else{//no feedy no eggies 
                FarmData.hasEgg = false;
            }
           chickenData.wasFed = false;//resets was fed every day
           chickenData.UpdateSprite();//changes sprite to that of the hungry chickie
        }
        foreach(GameObject rock in rocks){//grabs each rock in game world
            RockBehavior rockData = rock.GetComponent<RockBehavior>();//gets rock behavior component
            rockData.ResetRock();//resets each rock
        }
        foreach(GameObject tree in trees){//grabs each tree in game world
            TreeBehavior treeData = tree.GetComponent<TreeBehavior>();//get tree data
            treeData.ResetTree();//resets each tree
        }
        SaveSystem save = new SaveSystem();//creates a save object
        save.SaveGame(new GameData(cows, chickens, plants));//saves your game
    }
}
