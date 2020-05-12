using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Load_ChangeScene : MonoBehaviour
{
    [SerializeField] private string toScene = null;

    private SceneController sceneController;
    void Start()
    {
        sceneController = GameObject.FindGameObjectWithTag("GameController").GetComponent<SceneController>();
    }
    //Nikolo you will have to put your code inside of update above the sceneController line. This 
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sceneController.LoadScene(toScene);//loading new scene
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            sceneController.LoadScene(toScene);//loading new scene
        }

    }
}

