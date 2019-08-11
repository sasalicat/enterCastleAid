using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showFrame : MonoBehaviour {
    public Color activeColor;
    public Color normalColor;
    public Image frame;
    public Text numTxt;
    private int number; 
    public void changeNum(int offset) {
        number += offset;
        if (number < 0)
        {
            number = 0;
        }
        numTxt.text = "" + number;
    }
    public void onClick() {
        rolePanel.activeFrame = this;
        frame.color = activeColor;
    }
    public void unActive() {
        frame.color = normalColor;
    }
           
}
