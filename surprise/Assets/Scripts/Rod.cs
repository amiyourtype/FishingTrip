using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rod : Item
{
    public string name;
    public int efficiency; 
    public Sprite sprite;
    //public int price; 
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */

    public override void buy(Fisher fisher) //Equips this rod on player
    {
        fisher.currentRod = this;
        fisher.newRod();
    }
}
