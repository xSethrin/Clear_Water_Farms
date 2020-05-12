using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStatics : MonoBehaviour
{

    void OnMouseDown(){
        JackObject.stam-=5;
        Debug.Log("Stam: " + JackObject.stam);
        for(int i = 0; i < 10; i++){
            bool temp = FarmData.hasChicken[i];
            if(temp){
                Debug.Log("Here is a true in FarmData.hasChicken");
            }
            else{
                Debug.Log("Here is a false in FarmData.hasChicken");
            }
        }
        
        
        
    }
}
