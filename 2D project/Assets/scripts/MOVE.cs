using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE : MonoBehaviour
{
    float LB = 5;
    bool move = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (move == true)
        {
            transform.Translate(Vector3.right * LB * Time.deltaTime);
        }
    }
}
