using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    private int time = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time++;
        transform.position = new Vector3(500, 300 + (Mathf.Cos((((time / 200) + 3) * 175) * 4)) * 5, 0);
    }
}