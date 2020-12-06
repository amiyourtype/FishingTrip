using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaBar1 : MonoBehaviour
{
    public Fisher fisher;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(fisher.hooked)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 50);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 110);
        }
    }
}
