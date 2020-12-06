using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticket : Item
{
    //public int price;
    public int areaID;
    public Fisher fisher;
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

    public override void buy(Fisher fisher) //Moves player on to the next area
    {
        fisher.thisManager.updatePool(areaID);
    }
}
