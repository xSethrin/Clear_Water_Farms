using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
* This class updates data for the start of each day
*
*/
public class NewDayScript : MonoBehaviour{
    public Animator animator;
    public string sceneName;
    /**
    * This method updates data for the start of each day
    * It is ran when the player goes to sleep (clicks on the bed)
    */
    void OnMouseDown(){
        JackObject.stam = 150;//resets stamina
        for(int i = 0; i < 255; i++){//loops through all the plants
            if(FarmData.timesWatered[i] == 3){//if plant was watered 3 times it is ready to grow to the next stage
                FarmData.currentStage[i]++;
                FarmData.timesWatered[i] = 0;//resets times watered
            }
            FarmData.isWatered[i] = false;//sets is watered to false for each new day
        }
        for(int i = 0; i < 10; i++){//loops through the cows
            if(FarmData.cowWasFed[i]){//checks if the cow was fed so the cow will make milk.  yummy
                FarmData.hasMilk[i] = true;
            }
            else{//if cow was not fed no milky for you =(
                FarmData.hasMilk[i] = false;
            }
            FarmData.cowWasFed[i] = false;//restes to false each day
        }
        for(int i = 0; i < 10; i++){//loops through each chicken
            if(FarmData.chickenWasFed[i]){//checks if the cock was fed so you get your eggs
                FarmData.hasEgg[i] = true;
            }
            else{//no feedy no eggies 
                FarmData.hasEgg[i] = false;
            }
           FarmData.chickenWasFed[i] = false;//resets was fed every day
        }
        SaveSystem save = new SaveSystem();//creates a save object
        save.SaveGame(new GameData());//saves your game
       // animator.SetTrigger("FadeOut");
         SceneManager.LoadScene(sceneName);

    }

    public void  makeChange(){
       
    } 
}
