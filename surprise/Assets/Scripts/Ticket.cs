using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticket : Item
{
    //public int price;
    public int areaID;
    private Shop shop;
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
        if(poolID == 2)
        {
            createPool(stageTwoSpawns);
        }
        else if(poolID == 3)
        {
            createPool(stageThreeSpawns);
        }
        else if(poolID == 4)
        {
            createPool(stageFourSpawns);
        }
        else if(poolID == 5)
        {
            createPool(stageFiveSpawns);
        }
        fisher.thisManager.updatePool(areaID);
    }
}
