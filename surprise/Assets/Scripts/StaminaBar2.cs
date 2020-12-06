using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaBar2 : MonoBehaviour
{
    public double size;
    public Fisher fisher;
    // Start is called before the first frame update
    void Start()
    {
        //transform.localScale = new Vector3(1,size,1);
    }

    // Update is called once per frame
    void Update()
    {
        if(fisher.hooked)
        {
        size = fisher.target.stamina/100f * 1.2f;
        transform.localScale = new Vector3(1,(float)size,1);
        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 110);
        }
    }
}
