using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Show : MonoBehaviour
{
    public GameObject Shop;
    void OnTriggerExit2D(Collider2D collide)
    {
        Shop.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collide)
    {
        Shop.SetActive(true);
    }


    // Start is called before the first frame update
    void Start()
    {
        Shop.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
