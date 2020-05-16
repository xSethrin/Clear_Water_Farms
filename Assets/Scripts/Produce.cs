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
    public Sprite sprite;//sprite for produce

    /**
    * This constructor is used when creating produce object after being harvested
    *
    */
    public Produce(string produceName, int price, int quantity, Sprite sprite) {
        this.produceName = produceName;
        this.price = price;
        this.quantity = quantity;
        this.sprite = sprite;
    }

    /**
    * This constructor is used to create produce when loading a game
    *
    */
    public Produce(string produceName, int price, int quantity) {
        this.produceName = produceName;
        this.price = price;
        this.quantity = quantity;
        this.sprite = sprite;
    }

    public void UpdateSprite(){
        //need a way to update the sprite for the menu when we load game idk how to do it yet.
        //Talk to Sterling about it, he knows menus better
    }
}