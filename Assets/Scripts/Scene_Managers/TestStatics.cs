using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStatics : MonoBehaviour
{

    void OnMouseDown(){
        JackObject.stam-=5;
        Debug.Log("Stam: " + JackObject.stam);
        /**
        Debug.Log("Test object clicked");
        if(FarmData.chickenData != null){
            Debug.Log("Chicken Objects: " + FarmData.chickenData.Length);
        }
        else{
            Debug.Log("Chicken Objects is null");
        }
        if(FarmData.plantData != null){
            Debug.Log("Plant Objects: " + FarmData.plantData.Length);
        }
        else{
            Debug.Log("Plant Objects is null ");
        }
        if(FarmData.cowData != null){
            Debug.Log("Cow Objects: " + FarmData.cowData.Length);
        }
        else{
            Debug.Log("Cow Objects is null ");
        }
        */
        
    }
}
