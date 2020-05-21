using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LayerSorter : MonoBehaviour
{

    private SpriteRenderer parentRenderer; 
    private List<Tree> trees = new List<Tree>();

    

    // Start is called before the first frame update
    void Start()
    {
     parentRenderer = transform.parent.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
       
        if(collision.tag =="Tree"){
            Tree o = collision.GetComponent<Tree>();
            if(trees.Count ==0 ||o.MySpriteRenderer.sortingOrder-1<parentRenderer.sortingOrder ){
                 parentRenderer.sortingOrder = o.MySpriteRenderer.sortingOrder-1;
            }
           trees.Add(o);
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.tag == "Tree"){
            Tree o = collision.GetComponent<Tree>();
            trees.Remove(o);
            if(trees.Count==0){
                parentRenderer.sortingOrder = 10;
            }else {
                trees.Sort();
                parentRenderer.sortingOrder = trees[0].MySpriteRenderer.sortingOrder-1;
            }
        }
    }
}
