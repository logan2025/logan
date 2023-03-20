using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OTE : MonoBehaviour
{
    //creates a box store out sprite renderer information
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //sets the sprite renderer information to what information is in the component
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Ball 2 hit Floor");
        //access the color of sprite and sets the value of the color to red
        spriteRenderer.color = Color.red;
    }
}
