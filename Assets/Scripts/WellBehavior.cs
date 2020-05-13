using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is attached to the well object and will act as a way to fill watering can
public class WellBehavior : MonoBehaviour{
    void OnMouseDown(){
        JackObject.waterAmount = 30;
        JackObject.stam = JackObject.stam - (5 - JackObject.water);
    }
}
