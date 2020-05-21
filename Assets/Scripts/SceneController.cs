using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneController : MonoBehaviour
{
    public Animator animator; 
    public static string prevScene = "";
    public static string currentScene = "";
    private string levelTOLoad;

    public virtual void Start()
    {
        // Meant to be extended/overwritten by a scene script
        currentScene = SceneManager.GetActiveScene().name;
    }

    public void FadeToLevel(string level){
        levelTOLoad = level;
        animator.SetTrigger("FadeOut");
    }

    public void LoadScene(string sceneName)
    {
        //Debug.Log("loadingScene");
        prevScene = currentScene;
       // animator.SetTrigger("FadeOut");
      // System.Threading.Thread.Sleep(1000);
        SceneManager.LoadScene(sceneName);
    }





    }