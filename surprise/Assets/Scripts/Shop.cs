using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public Fisher fisher; //The fisherman
    public float radius; //How big the icon is
    public List<GameObject> inventory = new List<GameObject>();
    public bool shopOpen; //If shop is open, player can view and purchase items, otherwise shop is closed

    private Vector3 mousepos;
    // Start is called before the first frame update
    void Start()
    {
        shopOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonUp(0) && !fisher.hooked) //player clicked on icon when minigame not in progress
        {
            mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float dist = Vector3.Distance(transform.position, new Vector3(mousepos.x, mousepos.y, 0));
            if(dist < radius)
            {
                if(shopOpen)
                {
                    shopOpen = false;
                    foreach(GameObject item in inventory)
                    {
                        item.transform.position = new Vector3(item.transform.position.x, item.transform.position.y, 110);
                    }
                }
                else
                {
                    shopOpen = true;
                    foreach(GameObject item in inventory)
                    {
                        item.transform.position = new Vector3(item.transform.position.x, item.transform.position.y, 99);
                    }
                }
            }
            else if(shopOpen)
            {
                foreach(GameObject item in inventory)
                {
                    dist = Vector3.Distance(item.transform.position, new Vector3(mousepos.x, mousepos.y, 0));
                    if(dist < radius)
                    {
                        if(item.GetComponent<Item>().price <= fisher.money)
                        {
                            fisher.money -= item.GetComponent<Item>().price;
                            item.GetComponent<Item>().buy(fisher);
                        }
                    }
                }
            }
        }
    }

    void OnGUI()
    {
        if(shopOpen)
        {
            GUI.color = Color.yellow;
            int xPos = 10;
            foreach(GameObject item in inventory)
            {
                GUI.Label(new Rect(xPos,200,100,200), "$" + item.GetComponent<Item>().price);
                xPos += 100;
            }
        }
    }
}
