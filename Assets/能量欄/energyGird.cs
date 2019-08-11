using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energyGird : MonoBehaviour {
    public Sprite sprite;
    public Image icon;
    public void randomColor(){
        icon.image = sprite;
        int kind= Random.Range(0,3);
    }
}
