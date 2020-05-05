using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Produce {

    public string nameOf;
    public int price, quantity;
    public Sprite sprite;

    public Produce(string nameOf, int price, int quantity, Sprite sprite) {
        this.nameOf = nameOf;
        this.price = price;
        this.quantity = quantity;
        this.sprite = sprite;
    }
}