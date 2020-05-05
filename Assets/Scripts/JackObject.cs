using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackObject : MonoBehaviour{

    public static string currentTool = "hand";
    public int stam = 100, gold = 500, water = 1, hoe = 1, sickle = 1, hammer = 1, axe = 1;
    //inventory array?
    public bool[] isFull = new bool[6];
    public static List<Produce> slots = new List<Produce>();

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

   
}
