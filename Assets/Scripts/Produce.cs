using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* This class is used to store data about produce player gets from farm
*
*/
public class Produce {

    public string produceName;//name of produce
    public int price, quantity;//quantity of produce

    /**
    * This constructor is used to create produce when loading a game
    *
    */
    public Produce(string produceName, int price, int quantity) {
        this.produceName = produceName;
        this.price = price;
        this.quantity = quantity;
    }
}