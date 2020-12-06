using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodInUse : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    //public Sprite rodSprite;
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
        GUI.Label(new Rect(110,100,100,200), "Rod in use: " + name);
    }

    public void updateRod(Rod rod)
    {
        spriteRenderer.sprite = rod.sprite;
        name = rod.name;
    }
}
