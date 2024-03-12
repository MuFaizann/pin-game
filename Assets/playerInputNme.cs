using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerInputNme : MonoBehaviour
{
    public InputField PlayerName;
    public static string myPlayerName;
    public Text ShowName;



    public void DisplayName()
    {
        myPlayerName = PlayerName.text; // assign input to string
        ShowName.text = myPlayerName; //assign string to textbox
    }
}

