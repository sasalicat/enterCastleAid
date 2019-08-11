using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randIntPanel : MonoBehaviour {
    public Text numTxt;//手動拉取
    public void onClick()
    {
        int num= Random.Range(0, 101);
        numTxt.text = "" + num;
    }
}
