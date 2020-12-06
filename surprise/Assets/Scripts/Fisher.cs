using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisher : MonoBehaviour
{
    public int money;
    public Rod currentRod;
    public bool hooked;
    public Fish target; //the fish currently being reeled
    public lastCaught lastCatch;
    public RodInUse rodInUse;

    private Vector3 mousepos;
    //public Bait

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(Input.GetMouseButtonUp(0) && !hooked)
        {
            transform.position = new Vector3(mousepos.x, mousepos.y, 50);
            Vector3 variability = new Vector3(Random.Range(-150, 160), Random.Range(-150, 160), 50);
            transform.position += variability;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!hooked)
        {
            Debug.Log("got one");
            target = collision.gameObject.GetComponent<Fish>();
        }
    }

    void OnGUI()
    {
        GUI.color = Color.green;
        GUI.Label(new Rect(10,100,100,200), "$" + money.ToString());
    }

    public void newCatch()
    {
        lastCatch.updateCatch(target);
    }

    public void newRod()
    {
        rodInUse.updateRod(currentRod);
    }
}
