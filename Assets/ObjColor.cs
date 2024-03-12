// this script is attached to the color dropdown. Use the On Value Changed event in the Dropdown component.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjColor : MonoBehaviour
{
    public Dropdown ColorSelect; //ColorDropdown
  //  public Text ColorText;
    public GameObject Rotator; //PlayerCapsule


    // Start is called before the first frame update
    void Start()
    {
      //  Rotator.GetComponent<Renderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChooseColor() // use in the change event for the dropdown
    {
        switch (ColorSelect.value)
        {
            case 1:
               // ColorText.text = ColorDropdown.options[1].text;
               // GetComponent<SpriteRenderer>().color = Color.red;
               // Rotator.GetComponent<Renderer>().material.color = Color.red;
                Rotator.GetComponent<SpriteRenderer>().color = Color.red;
                break;
            case 2:
              //  ColorText.text = ColorDropdown.options[2].text;
                Rotator.GetComponent<SpriteRenderer>().color = Color.white;
                break;
            case 3:
               // ColorText.text = ColorDropdown.options[3].text;
                Rotator.GetComponent<SpriteRenderer>().color = Color.blue;
                break;
            default: // color if not one of the choices is selected
               // ColorText.text = ColorDropdown.options[0].text;
                Rotator.GetComponent<SpriteRenderer>().color = Color.black;
                break;
        }
    }
   
}
