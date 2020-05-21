using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{
   void Awake(){
        GameObject [] music = GameObject.FindGameObjectsWithTag("music");
        Debug.Log("music count: " + music.Length);
        
        if(music.Length > 1){
            if(music.Length == 3){
                Destroy(music[1]);
                Destroy(music[2]);
            }
            else if(music[0].GetComponent<SongData>().songName == music[1].GetComponent<SongData>().songName){
                Destroy(music[1]);
             }
            else{
                Destroy(music[0]);
            }
       }
       DontDestroyOnLoad(this.gameObject);
   }
}
