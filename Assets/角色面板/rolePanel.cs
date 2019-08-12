using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rolePanel : MonoBehaviour {
    protected static showFrame nowActive=null;
    public static showFrame activeFrame {
        set
        {
            if(nowActive!=null)
                nowActive.unActive();
            nowActive = value;
        }
    }
    public  void plusActiveNum(int offset){
        if(nowActive!=null)
            nowActive.changeNum(offset);
    }
    public  void setActiveNum(int num)
    {
        if (nowActive != null)
            nowActive.setNum(num);
    }
}
