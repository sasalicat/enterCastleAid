using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerPanel : MonoBehaviour {

    public Text moneyText;
    public Text levelText;
    protected int money;
    protected int level;
    public int Money
    {
        set
        {
            if (value >= 0)
            {
                money = value;
            }
            else
            {
                money = 0;
            }
            moneyText.text = money + "";
        }
        get {
            return money;
        }
    }
    public int Level
    {
        set
        {
            if (value >= 1)
            {
                level = value;
            }
            else
            {
                level = 1;
            }
            levelText.text = level + "";
        }
        get
        {
            return level;
        }
    }
    public void changeMoney(int offset)
    {
        Money += offset;
    }
    public void changeLevel(int offset)
    {
        Level += offset;
    }
}
