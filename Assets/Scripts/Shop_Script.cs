using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Script : MonoBehaviour
{
    
    public GameObject FloatingTextPrefab;
    private int seedsCost = 20;
    private int seedsCount = 1;
    private int cowCost = 650;
    private int cowInventory = 10;
    private int milkCost = 150;
    private int eggCost = 80;
    private int chickenInventory = 10;
    private int chickenCost = 350;
    private int[] level1 ={10,10,200};//[lumber, ore, gold]
    private int[] level2 ={25,25,300};
    private int[] level3 ={50,50,400};
    private int[] level4 ={100,100,500}; 
/*
Method for selling tomatoes
*/
    public  void sellTomatoes()
    {
        for(int i=0; i < JackObject.slots.Count; i++)
        {
            if (JackObject.slots[i].produceName == "tomato")
            {
                JackObject.gold = JackObject.gold + (JackObject.slots[i].quantity * JackObject.slots[i].price);
                JackObject.slots.RemoveAt(i);
            }
        }
        Debug.Log("Selling Tomatoes");
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
        }
        Debug.Log(JackObject.gold + " " + JackObject.seeds);
        //Debug.Log("Buying Seeds");
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
            Debug.Log("Upgrading Axe to level "+ JackObject.axe+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.axe == 1 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.axe = 2;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            Debug.Log("Upgrading Axe to level "+ JackObject.axe+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.axe == 2 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.axe = 3;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            Debug.Log("Upgrading Axe to level "+ JackObject.axe+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.axe == 3 && JackObject.lumber >= level3[0] && JackObject.ore >= level3[1] && JackObject.gold >= level3[2])
        {
            JackObject.axe = 4;
            JackObject.lumber -= level3[0];
            JackObject.ore -= level3[1];
            JackObject.gold -= level3[2];
            Debug.Log("Upgrading Axe to level "+ JackObject.axe+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.axe == 4 )
        {
              Debug.Log("Your Axe is already maxed at level"+ JackObject.axe);
        }else{
            Debug.Log("you don't have enough to upgrade");
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
            Debug.Log("Upgrading Hammer to level "+ JackObject.hammer+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.hammer == 1 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.hammer = 2;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            Debug.Log("Upgrading Hammer to level "+ JackObject.hammer+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.hammer == 2 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.hammer = 3;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            Debug.Log("Upgrading Hammer to level "+ JackObject.hammer+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.hammer == 3 && JackObject.lumber >= level3[0] && JackObject.ore >= level3[1] && JackObject.gold >= level3[2])
        {
            JackObject.hammer = 4;
            JackObject.lumber -= level3[0];
            JackObject.ore -= level3[1];
            JackObject.gold -= level3[2];
            Debug.Log("Upgrading Hammer to level "+ JackObject.hammer+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.hammer == 4 )
        {
              Debug.Log("Your Hammer is already maxed at level"+ JackObject.hammer);
        }else{
            Debug.Log("you don't have enough to upgrade");
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
            Debug.Log("Upgrading hoe to level "+ JackObject.hoe+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.hoe == 1 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.hoe = 2;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            Debug.Log("Upgrading hoe to level "+ JackObject.hoe+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.hoe == 2 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.hoe = 3;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            Debug.Log("Upgrading hoe to level "+ JackObject.hoe+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.hoe == 3 && JackObject.lumber >= level3[0] && JackObject.ore >= level3[1] && JackObject.gold >= level3[2])
        {
            JackObject.hoe = 4;
            JackObject.lumber -= level3[0];
            JackObject.ore -= level3[1];
            JackObject.gold -= level3[2];
            Debug.Log("Upgrading hoe to level "+ JackObject.hoe+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.hoe == 4 )
        {
              Debug.Log("Your hoe is already maxed at level"+ JackObject.hoe);
        }else{
            Debug.Log("you don't have enough to upgrade");
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
            Debug.Log("Upgrading sickle to level "+ JackObject.sickle+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.sickle == 1 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.sickle = 2;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            Debug.Log("Upgrading sickle to level "+ JackObject.sickle+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.sickle == 2 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.sickle = 3;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            Debug.Log("Upgrading sickle to level "+ JackObject.sickle+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.sickle == 3 && JackObject.lumber >= level3[0] && JackObject.ore >= level3[1] && JackObject.gold >= level3[2])
        {
            JackObject.sickle = 4;
            JackObject.lumber -= level3[0];
            JackObject.ore -= level3[1];
            JackObject.gold -= level3[2];
            Debug.Log("Upgrading sickle to level "+ JackObject.sickle+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.sickle == 4 )
        {
              Debug.Log("Your sickle is already maxed at level"+ JackObject.sickle);
        }else{
            Debug.Log("you don't have enough to upgrade");
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
            Debug.Log("Upgrading watering can to level "+ JackObject.water+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.water == 1 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.water = 2;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            Debug.Log("Upgrading watering can to level "+ JackObject.water+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.water == 2 && JackObject.lumber >= level2[0] && JackObject.ore >= level2[1] && JackObject.gold >= level2[2])
        {
            JackObject.water = 3;
            JackObject.lumber -= level2[0];
            JackObject.ore -= level2[1];
            JackObject.gold -= level2[2];
            Debug.Log("Upgrading watering can to level "+ JackObject.water+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.water == 3 && JackObject.lumber >= level3[0] && JackObject.ore >= level3[1] && JackObject.gold >= level3[2])
        {
            JackObject.water = 4;
            JackObject.lumber -= level3[0];
            JackObject.ore -= level3[1];
            JackObject.gold -= level3[2];
            Debug.Log("Upgrading watering can to level "+ JackObject.water+" lumber = "+JackObject.lumber+" ore = "+JackObject.ore+" gold "+ JackObject.gold);
        }else if (JackObject.water == 4 )
        {
              Debug.Log("Your watering can is already maxed at level"+ JackObject.water);
        }else{
            Debug.Log("you don't have enough to upgrade");
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
                    Debug.Log(JackObject.gold + " "+"Bought cow");
                    flag = false;
                }
            }
            if (flag)
            {
                Debug.Log("Full on cows");
            }
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
                    Debug.Log(JackObject.gold + " "+"Bought chicken");
                    flag = false;
                }
            }
            if (flag)
            {
                Debug.Log("Full on chickens");
            }
            

        }
       // Debug.Log("Buying Chicken");
    }
/*
Method for selling milk
*/
    public void SellMilk()
    {
       for(int i=0; i < JackObject.slots.Count; i++)
        {
            if (JackObject.slots[i].produceName == "milk")
            {
                JackObject.gold = JackObject.gold + (JackObject.slots[i].quantity * JackObject.slots[i].price);
                JackObject.slots.RemoveAt(i);
                
            }
        }
        Debug.Log("Selling milk");
    }
/*
Method for selling eggs
*/
    public void SellEggs()
    {
        for(int i=0; i < JackObject.slots.Count; i++)
        {
            if (JackObject.slots[i].produceName == "egg")
            {
                JackObject.gold = JackObject.gold + (JackObject.slots[i].quantity * JackObject.slots[i].price);
                JackObject.slots.RemoveAt(i);
                
            }
        }
        Debug.Log("Selling eggs");
    }

    
}
