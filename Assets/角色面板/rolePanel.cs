using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rolePanel : MonoBehaviour {
    protected static showFrame nowActive;
    public static showFrame activeFrame {
        set
        {
            nowActive.unActive();
            nowActive = value;
        }
    }
    public void numChange(int offset)
    {
        nowActive.changeNum(offset);
    }
}
