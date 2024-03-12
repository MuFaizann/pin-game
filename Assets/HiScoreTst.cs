using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HiScoreTst : MonoBehaviour
{
    public Text NameTextTwo;

    // Update is called once per frame
    void Update()
    {
        NameTextTwo.text = Score.HighestPinCount.ToString();
    }
}
