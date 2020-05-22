using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Show : MonoBehaviour
{
    public GameObject Shop;
    public GameObject AxePriceText, AxeLumberText, AxeOreText, AxeMessage, HammerPriceText, HammerLumberText, HammerOreText, HammerMessage, HoePriceText, HoeLumberText, HoeOreText, HoeMessage, SicklePriceText, SickleLumberText, SickleOreText, SickleMessage, WaterPriceText, WaterLumberText, WaterOreText, WaterMessage;
    private int[] level1 = {10,10,200};//[lumber, ore, gold]
    private int[] level2 = {25,25,300};
    private int[] level3 = {50,50,400};
    private int[] level4 = {100,100,500}; 
    public int [,] prices = new int [5,2] { {200, 10}, {300, 25}, {400, 50}, {500, 100}, {0, 0} };

    void OnTriggerExit2D(Collider2D collide)
    {
        Shop.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collide)
    {
        
        AxePriceText.GetComponent<UnityEngine.UI.Text>().text = "" + prices[JackObject.axe, 0];
        AxeLumberText.GetComponent<UnityEngine.UI.Text>().text = "" + prices[JackObject.axe, 1];
        AxeOreText.GetComponent<UnityEngine.UI.Text>().text = "" + prices[JackObject.axe, 01];
        AxeMessage.GetComponent<UnityEngine.UI.Text>().text = "";

        HammerPriceText.GetComponent<UnityEngine.UI.Text>().text = "" + prices[JackObject.hammer, 0];
        HammerLumberText.GetComponent<UnityEngine.UI.Text>().text = "" + prices[JackObject.hammer, 1];
        HammerOreText.GetComponent<UnityEngine.UI.Text>().text = "" + prices[JackObject.hammer, 1];
        HammerMessage.GetComponent<UnityEngine.UI.Text>().text = "";


        HoePriceText.GetComponent<UnityEngine.UI.Text>().text = "" + prices[JackObject.hoe, 0];
        HoeLumberText.GetComponent<UnityEngine.UI.Text>().text = "" + prices[JackObject.hoe, 1];
        HoeOreText.GetComponent<UnityEngine.UI.Text>().text = "" + prices[JackObject.hoe, 1];
        HoeMessage.GetComponent<UnityEngine.UI.Text>().text = "";


        SicklePriceText.GetComponent<UnityEngine.UI.Text>().text = "" + prices[JackObject.sickle, 0];
        SickleLumberText.GetComponent<UnityEngine.UI.Text>().text = "" + prices[JackObject.sickle, 1];
        SickleOreText.GetComponent<UnityEngine.UI.Text>().text = "" + prices[JackObject.sickle, 1];
        SickleMessage.GetComponent<UnityEngine.UI.Text>().text = "";

        WaterPriceText.GetComponent<UnityEngine.UI.Text>().text = "" + prices[JackObject.water, 0];
        WaterLumberText.GetComponent<UnityEngine.UI.Text>().text = "" + prices[JackObject.water, 1];
        WaterOreText.GetComponent<UnityEngine.UI.Text>().text = "" + prices[JackObject.water, 1];
        WaterMessage.GetComponent<UnityEngine.UI.Text>().text = "";

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
