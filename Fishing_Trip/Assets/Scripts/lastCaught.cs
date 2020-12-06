using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastCaught : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite lastFish;
    public string name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        GUI.color = Color.yellow;
        GUI.Label(new Rect(10,530,100,200), "Last caught: " + name);
    }

    public void updateCatch(Fish fish)
    {
        spriteRenderer.sprite = fish.trueForm;
        name = fish.name;
    }
}
