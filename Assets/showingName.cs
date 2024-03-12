using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showingName : MonoBehaviour
{
    public Text NameText;

    // Update is called once per frame. Easy to use Update so we don't have to do anything special to show the name.
    void Update()
    {
        NameText.text = playerInputNme.myPlayerName;
    }
}
