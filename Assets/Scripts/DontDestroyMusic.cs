using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{
   void Awake(){
        GameObject [] music = GameObject.FindGameObjectsWithTag("music");   
        //Debug.Log("Music: " + music.Length);   
        for(int i = 0; i < music.Length; i++){
            //Debug.Log(i + " " + music[i].GetComponent<SongData>().songName);
        }  
        if(music.Length > 1){
            if(music[0].GetComponent<SongData>().songName == music[1].GetComponent<SongData>().songName ){
                for(int i = 1; i < music.Length; i++){
                    Destroy(music[i]);
                }  
             }
            else{
                Destroy(music[0]);
            }
       }
       DontDestroyOnLoad(this.gameObject);
   }
}
