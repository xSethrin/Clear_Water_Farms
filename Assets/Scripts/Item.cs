using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        Buy_Seeds,
        Sell_Tomatoes

    }

    public static int GetCost(ItemType itemType)
    {
        switch (itemType)
        {
            default:
            case ItemType.Buy_Seeds: return 20;
            case ItemType.Sell_Tomatoes: return -70; 
        }
    }

   

}
