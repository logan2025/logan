using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OCE  : MonoBehaviour
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor") 
        {
         Debug.Log("Ball 1 hit floor");
            // access the color of sprite and sets the value of the color to blue
            spriteRenderer.color = Color.blue;
        }
       
    }
        
}
