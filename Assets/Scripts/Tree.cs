using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Tree : MonoBehaviour,IComparable<Tree>
{
    public SpriteRenderer MySpriteRenderer {get;set;}
    // Start is called before the first frame update
   
   public int CompareTo(Tree other){
        if(MySpriteRenderer.sortingOrder>other.MySpriteRenderer.sortingOrder){
            return 1;
        }else if(MySpriteRenderer.sortingOrder< other.MySpriteRenderer.sortingOrder){
            return -1;
        }
        return 0;
    }
   
    void Start()
    {
        MySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
