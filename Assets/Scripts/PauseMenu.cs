using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
* This is the code used to control the pause/inventory menu
*
*/
public class PauseMenu : MonoBehaviour{

   public static bool isPaused = false;
   public GameObject playerMenuUI, StaminaTextField, GoldTextField, LumberTextField, OreTextField;
   public string stamina, lumber, ore;
   public GameObject[] inventorySlots;
   public GameObject[] slotQuantity; 
   public Sprite milk, egg, tomato;


    // Update is called once per frame
    void Update(){
        
        if (Input.GetKeyDown("i")){
            if(isPaused){
                Resume();
            }
            else{
                Pause();
                StaminaTextField.GetComponent<UnityEngine.UI.Text>().text = "Stamina: " + JackObject.stam;
                GoldTextField.GetComponent<UnityEngine.UI.Text>().text = "Gold: " + JackObject.gold;
                LumberTextField.GetComponent<UnityEngine.UI.Text>().text = "Lumber: " + JackObject.lumber;
                OreTextField.GetComponent<UnityEngine.UI.Text>().text = "Ore: " + JackObject.ore;
                inventorySlots = GameObject.FindGameObjectsWithTag("slot");
                slotQuantity = GameObject.FindGameObjectsWithTag("Quantity");
                for(int i = 0; i < JackObject.slots.Count; i++){
                    if(JackObject.slots[i].produceName == "milk"){
                        inventorySlots[i].GetComponent<Image>().sprite = milk;
                        slotQuantity[i].GetComponent<UnityEngine.UI.Text>().text = "" + JackObject.slots[i].quantity;
                    }
                    else if(JackObject.slots[i].produceName == "egg"){
                        inventorySlots[i].GetComponent<Image>().sprite = egg;
                        slotQuantity[i].GetComponent<UnityEngine.UI.Text>().text = "" + JackObject.slots[i].quantity;
                    }
                    else if(JackObject.slots[i].produceName == "tomato"){
                        inventorySlots[i].GetComponent<Image>().sprite = tomato;
                        slotQuantity[i].GetComponent<UnityEngine.UI.Text>().text = "" + JackObject.slots[i].quantity;
                    }
                }
            }
        }
    }

    /**
    * This method resumes the game
    */
    public void Resume(){
        playerMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    /**
    * This method pauses the game
    *
    */
    void Pause(){
        playerMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    /**
    * This method quits the game
    *
    */
    public void QuitGame(){
        Application.Quit();
    }
}
