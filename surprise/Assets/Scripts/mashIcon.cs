using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mashIcon : MonoBehaviour
{
    public Fisher fisher;
    public SpriteRenderer spriteRenderer;
    public Sprite mash1;
    public Sprite mash2;
    private bool animator;
    public int timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 5;
        animator = false;
        //spriteRenderer.sprite = mash2;
    }

    // Update is called once per frame
    void Update()
    {
        if(fisher.hooked)
        {
            transform.position = new Vector3(fisher.target.transform.position.x, fisher.target.transform.position.y - 40, 10);
            timer -= 1;
            if(timer <= 0)
            {
                if(animator)
                {
                    spriteRenderer.sprite = mash2;
                    animator = false;
                }
                else 
                {
                    spriteRenderer.sprite = mash1;
                    animator = true;
                }
                timer = 2;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 110);
        }
    }
}
