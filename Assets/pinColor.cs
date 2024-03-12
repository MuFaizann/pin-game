using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinColor : MonoBehaviour
{

  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
           // GetComponent<Renderer>().material.color = Color.red;
           GetComponent<SpriteRenderer>().color = new Color(35, 87, 137);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
           // GetComponent<Renderer>().material.color = Color.green;
           GetComponent<SpriteRenderer>().color = Color.black;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
           // GetComponent<Renderer>().material.color = Color.blue;
           GetComponent<SpriteRenderer>().color = Color.yellow;
        }
    }

  /*  public void ColorChanger()
    {
        
    
        if(Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
    

    }*/
}

