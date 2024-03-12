using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderPin : MonoBehaviour
{
    public Slider mySliderTwo; // slider is set from 2 to 6 with start value of 4, same as speed in PlayerMovement
    public Text speedTextTwo;
    public static float speed;

    // Update is called once per frame
    void Update()
    {
        speed = mySliderTwo.value;
        speedTextTwo.text = speed.ToString("f2"); // float with two decimals
    }
}
