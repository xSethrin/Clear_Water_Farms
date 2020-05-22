using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Script : MonoBehaviour
{
    
    private int seedsCost = 20, seedsCount = 1, cowCost = 650, cowInventory = 10, chickenInventory = 10, chickenCost = 350, fodderCost = 10;
    private int[] level1 ={10,10,200}, level2 ={25,25,300}, level3 ={50,50,400}, level4 ={100,100,500}; 
    public GameObject AxeMessage, HammerMessage, HoeMessage, SickleMessage, WaterMessage, BuyFodderMessage, BuyCowMessage, BuyChickenMessage, SellMilkMessage, 
    SellEggMessage, BuySeedMessage, sellTomatoMessage;


/*
Method for selling tomatoes
*/
    public  void sellTomatoes()
    {
        bool flag = true;
        for(int i=0; i < JackObject.slots.Count; i++)
        {
            if (JackObject.slots[i].produceName == "tomato")
            {
                JackObject.gold = JackObject.gold + (JackObject.slots[i].quantity * JackObject.slots[i].price);
                JackObject.slots.RemoveAt(i);
                SellTomoatoMessage.GetComponent<UnityEngine.UI.Text>().text = "Sold Tomatoes";
                flag = false;
            }
        }
        if(flag){
            SellTomoatoMessage.GetComponent<UnityEngine.UI.Text>().text = "No Tomatoes to Sell";

        }
    }

    /*
    Method for testing output on button click
    */
    public void testoutput()
    {
        Debug.Log("Testing click");
    }
/*
Method for buying seeds. 
*/
    public  void buySeeds()
    {
        if(JackObject.gold > seedsCost)
        {
            JackObject.gold -= seedsCost;
            JackObject.seeds +=seedsCount;
            BuySeedMessage.GetComponent<UnityEngine.UI.Text>().text = "Bought Seeds";
        }
        else{
            BuySeedMessage.GetComponent<UnityEngine.UI.Text>().text = "Insufficient Funds";
        }
    }
/*
Method for upgrading axe
*/
    public void upgradeAxe()
    {
        if (JackObject.axe == 0 && JackObject.lumber >= level1[0] && JackObject.ore >= level1[1] && JackObject.gold >= level1[2])
        {
            JackObject.axe = 1;
            JackObject.lumber -= level1[0];
            JackObject.ore -= level1[1];
            JackObject.gold -= level1[2];
            AxeMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.axe == 1 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.axe = 2;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            AxeMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.axe == 2 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.axe = 3;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            AxeMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.axe == 3 && JackObject.lumber >= level3[0] && JackObject.ore >= level3[1] && JackObject.gold >= level3[2])
        {
            JackObject.axe = 4;
            JackObject.lumber -= level3[0];
            JackObject.ore -= level3[1];
            JackObject.gold -= level3[2];
            AxeMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.axe == 4 )
        {
            AxeMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Fully Upgraded";
            //Debug.Log("Your Axe is already maxed at level"+ JackObject.axe);
        }else{
            AxeMessage.GetComponent<UnityEngine.UI.Text>().text = "Insufficient Funds";
            //Debug.Log("you don't have enough to upgrade");
        }
    }
 /*
Method for upgrading hammer
*/      
    public void upgradeHammer()
    {
        if (JackObject.hammer == 0 && JackObject.lumber >= level1[0] && JackObject.ore >= level1[1] && JackObject.gold >= level1[2])
        {
            JackObject.hammer = 1;
            JackObject.lumber -= level1[0];
            JackObject.ore -= level1[1];
            JackObject.gold -= level1[2];
            HammerMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.hammer == 1 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.hammer = 2;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            HammerMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.hammer == 2 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.hammer = 3;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            HammerMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.hammer == 3 && JackObject.lumber >= level3[0] && JackObject.ore >= level3[1] && JackObject.gold >= level3[2])
        {
            JackObject.hammer = 4;
            JackObject.lumber -= level3[0];
            JackObject.ore -= level3[1];
            JackObject.gold -= level3[2];
            HammerMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.hammer == 4 )
        {
            HammerMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Fully Upgraded";
        }
        else{
            HammerMessage.GetComponent<UnityEngine.UI.Text>().text = "Insufficient Funds";
        }
    }

/*
Method for upgrading hoe
*/
    public void upgradeHoe()
    {
       if (JackObject.hoe == 0 && JackObject.lumber >= level1[0] && JackObject.ore >= level1[1] && JackObject.gold >= level1[2])
        {
            JackObject.hoe = 1;
            JackObject.lumber -= level1[0];
            JackObject.ore -= level1[1];
            JackObject.gold -= level1[2];
            HoeMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.hoe == 1 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.hoe = 2;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            HoeMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.hoe == 2 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.hoe = 3;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            HoeMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.hoe == 3 && JackObject.lumber >= level3[0] && JackObject.ore >= level3[1] && JackObject.gold >= level3[2])
        {
            JackObject.hoe = 4;
            JackObject.lumber -= level3[0];
            JackObject.ore -= level3[1];
            JackObject.gold -= level3[2];
            HoeMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.hoe == 4 )
        {
            HoeMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Fully Upgraded";
        }else{
            HoeMessage.GetComponent<UnityEngine.UI.Text>().text = "Insufficient Funds";
        }
    }
/*
Method for upgrading sickle
*/
    public void upgradeSickle()
    {
        if (JackObject.sickle == 0 && JackObject.lumber >= level1[0] && JackObject.ore >= level1[1] && JackObject.gold >= level1[2])
        {
            JackObject.sickle = 1;
            JackObject.lumber -= level1[0];
            JackObject.ore -= level1[1];
            JackObject.gold -= level1[2];
            SickleMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.sickle == 1 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.sickle = 2;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            SickleMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.sickle == 2 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.sickle = 3;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            SickleMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.sickle == 3 && JackObject.lumber >= level3[0] && JackObject.ore >= level3[1] && JackObject.gold >= level3[2])
        {
            JackObject.sickle = 4;
            JackObject.lumber -= level3[0];
            JackObject.ore -= level3[1];
            JackObject.gold -= level3[2];
            SickleMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.sickle == 4 )
        {
            SickleMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Fully Upgraded";
        }else{
            SickleMessage.GetComponent<UnityEngine.UI.Text>().text = "Insufficient Funds";
        }
    }
/*
Method for upgrading watering can
*/
    public void upgradeWateringCan()
    {
        if (JackObject.water == 0 && JackObject.lumber >= level1[0] && JackObject.ore >= level1[1] && JackObject.gold >= level1[2])
        {
            JackObject.water = 1;
            JackObject.lumber -= level1[0];
            JackObject.ore -= level1[1];
            JackObject.gold -= level1[2];
            WaterMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.water == 1 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.water = 2;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            WaterMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.water == 2 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.water = 3;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            WaterMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.water == 3 && JackObject.lumber >= level3[0] && JackObject.ore >= level3[1] && JackObject.gold >= level3[2])
        {
            JackObject.water = 4;
            JackObject.lumber -= level3[0];
            JackObject.ore -= level3[1];
            JackObject.gold -= level3[2];
            WaterMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Upgraded";
        }else if (JackObject.water == 4 )
        {
            WaterMessage.GetComponent<UnityEngine.UI.Text>().text = "Tool Fully Upgraded";
        }
        else{
            WaterMessage.GetComponent<UnityEngine.UI.Text>().text = "Insufficient Funds";
        }
    }

    /**
    * This method is used for buying fodder
    *
    */
    public void BuyFodder(){
        if(JackObject.gold >= fodderCost){
            JackObject.fodder++;
            JackObject.gold-=10;
            BuyFodderMessage.GetComponent<UnityEngine.UI.Text>().text = "Bought Fodder";
        }
        else{
            BuyFodderMessage.GetComponent<UnityEngine.UI.Text>().text = "Insufficient Funds";
        }
        
    }

/*
Method for buying Cows
*/
    public void BuyCow()
    {
        if(JackObject.gold >= cowCost)
        {
            bool flag = true;
            for(int i=0; i <cowInventory; i++)
            {
                if (!FarmData.hasCow[i])
                {
                    FarmData.hasCow[i] = true;
                    JackObject.gold -= cowCost;
                    i = cowInventory;
                    BuyCowMessage.GetComponent<UnityEngine.UI.Text>().text = "Bought a Cow";
                    flag = false;
                }
            }
            if (flag)
            {
                BuyCowMessage.GetComponent<UnityEngine.UI.Text>().text = "Barn Full";
            }
        }
        else{
            BuyCowMessage.GetComponent<UnityEngine.UI.Text>().text = "Insufficient Funds";
        }
    }
/*
Method for buying chickens
*/
    public void BuyChicken()
    {
       if(JackObject.gold >= chickenCost)
        {
            bool flag = true;
            for(int i=0; i < chickenInventory; i++)
            {
                if (!FarmData.hasChicken[i])
                {
                    FarmData.hasChicken[i] = true;
                    JackObject.gold -= chickenCost;
                    i = chickenInventory;
                    BuyChickenMessage.GetComponent<UnityEngine.UI.Text>().text = "Bought a Chicken";
                    flag = false;
                }
            }
            if (flag)
            {
                BuyChickenMessage.GetComponent<UnityEngine.UI.Text>().text = "Coop Full";
            }
            

        }
        else{
            BuyChickenMessage.GetComponent<UnityEngine.UI.Text>().text = "Insufficient Funds";
        }
    }
/*
Method for selling milk
*/
    public void SellMilk()
    {
        bool flag = true;
        for(int i=0; i < JackObject.slots.Count; i++)
        {
            if (JackObject.slots[i].produceName == "milk")
            {
                JackObject.gold = JackObject.gold + (JackObject.slots[i].quantity * JackObject.slots[i].price);
                JackObject.slots.RemoveAt(i);
                SellMilkMessage.GetComponent<UnityEngine.UI.Text>().text = "Sold Milk"; 
                flag = false;   
            }
                
        }
        if(flag){
            SellMilkMessage.GetComponent<UnityEngine.UI.Text>().text = "No Milk to Sell";
        }  
    }
/*
Method for selling eggs
*/
    public void SellEggs()
    {
        bool flag = true;
        for(int i=0; i < JackObject.slots.Count; i++)
        {
            if (JackObject.slots[i].produceName == "egg")
            {
                JackObject.gold = JackObject.gold + (JackObject.slots[i].quantity * JackObject.slots[i].price);
                JackObject.slots.RemoveAt(i);
                SellEggMessage.GetComponent<UnityEngine.UI.Text>().text = "Sold Eggs"; 
                flag = false;   
            }
        }
        if(flag){
            SellEggMessage.GetComponent<UnityEngine.UI.Text>().text = "No Eggs to Sell";
        }
    }  
}
