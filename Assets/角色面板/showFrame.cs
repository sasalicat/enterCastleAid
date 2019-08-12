using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showFrame : MonoBehaviour {
    public Color activeColor;
    public Color normalColor;
    public Image frame;
    public Text numTxt;
    public int initNum;
    protected int number;
    public int Number
    {
        set
        {
            number = value;
            numTxt.text = "" + number;
        }
        get
        {
            return number;
        }
    }
    public void Start()
    {
        Number = initNum;
    }
    public void setNum(int num)
    {
        Number = num;
    } 
    public void changeNum(int offset) {
        Number += offset;
        if (Number < 0)
        {
            Number = 0;
        }
    }
    public void onClick() {
        rolePanel.activeFrame = this;
        frame.color = activeColor;
    }
    public void unActive() {
        frame.color = normalColor;
    }
           
}
