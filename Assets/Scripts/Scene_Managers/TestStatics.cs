using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStatics : MonoBehaviour
{

    void OnMouseDown(){
        JackObject.stam-=5;
        Debug.Log("Stam: " + JackObject.stam);
        for(int i = 0; i < 10; i++){
            if(FarmData.hasChicken[i]){
                Debug.Log("Here is a true in FarmData.hasChicken");
            }
            else{
                Debug.Log("Here is a false in FarmData.hasChicken");
            }
        }
        for(int i = 0; i < 10; i++){
            if(FarmData.hasCow[i]){
                Debug.Log("Here is a true in FarmData.hasCow");
            }
            else{
                Debug.Log("Here is a false in FarmData.hascow");
            }
        }
        GameObject [] chickens = GameObject.FindGameObjectsWithTag("Chicken");
        foreach(GameObject chicken in chickens){
            ChickenBehavior chickenData = chicken.GetComponent<ChickenBehavior>();
            if(chickenData.hasChicken){
                Debug.Log("local game object hasChicken is true");
            }
            else{
                Debug.Log("local game object hasChicken is false");

            }
        }
        GameObject [] cows = GameObject.FindGameObjectsWithTag("Cow");
        foreach(GameObject cow in cows){
            CowBehavior cowData = cow.GetComponent<CowBehavior>();
            if(cowData.hasCow){
                Debug.Log("local game object hasCow is true");
            }
            else{
                Debug.Log("local game object hasCow is false");

            }
        }
        
        
        
    }
}
