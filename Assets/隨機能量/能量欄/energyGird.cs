using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energyGird : MonoBehaviour {
    public Sprite sprite;
    public Image icon;
    public void randomColor(){
        icon.sprite = sprite;
        int kind= Random.Range(0,3);
        switch (kind)
        {
            case 0:
                {
                    icon.color = Color.red;
                    break;
                }
            case 1:
                {
                    icon.color = Color.green;
                    break;
                }
            case 2:
                {
                    icon.color = Color.blue;
                    break;
                }
        }
    }
}
