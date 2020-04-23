using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fieldBehavior : MonoBehaviour{

    public Sprite tilled, stage1, stage1W, stage2, stage2W, stage3;//each of these is used to update the sprite
    public int timeWatered = 0, count = 0;//timesWatered is used to detemer how many times the plant was watered.  this value will be used to check plants stage as well.
    //count is a temp value for testing, will remove later
    public bool isWatered;//isWatered checks if the plant was watered.  This will be used when player goes to sleep to properly update plant



    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }
    
    void OnMouseDown(){
        //TODO
        //we will not allow people to water tilled fields with no plant.
        //we will not allow people to plant in untilled soil
        //make sure to check these things in if statments

        if(count == 0){//change to hoe equipted
            Debug.Log("Field was tilled!");
            count++;
            GetComponent<SpriteRenderer>().sprite = tilled;
        }
        else if(count == 1){//change to seed equipted
            Debug.Log("Seed planted! at stage 1");
            count++;
            GetComponent<SpriteRenderer>().sprite = stage1;
        }
        else if (count == 2){
            Debug.Log("Stage 1 watered");
            count++;
            GetComponent<SpriteRenderer>().sprite = stage1W;
        }
        else if(count == 3){
            Debug.Log("plant grew! at stage 2");
            count++;
            GetComponent<SpriteRenderer>().sprite = stage2;
        }
         else if(count == 4){
            Debug.Log("stage two watered watered");
            count++;
            GetComponent<SpriteRenderer>().sprite = stage2W;
        }
         else if(count == 5){
            Debug.Log("plant grew! at stage 3");
            count++;
            GetComponent<SpriteRenderer>().sprite = stage3;
        }
         else if(count == 6){
            Debug.Log("harvested!");
            count = 0;
            GetComponent<SpriteRenderer>().sprite = tilled;
         }
    }
    
}