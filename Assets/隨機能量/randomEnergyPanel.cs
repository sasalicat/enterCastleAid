using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomEnergyPanel : MonoBehaviour {
    public GameObject girdPanel;
    public GameObject gird;
    protected int girdNum = 0;
    public const int MAX_GIRD_NUMBER = 20;
    protected List<GameObject> girds = new List<GameObject>();
    public int GirdNumber
    {
        set
        {
            Debug.Log("girdNumber newNum:" + value);
            int newNum = value;
            if (newNum > MAX_GIRD_NUMBER)
            {
                newNum = MAX_GIRD_NUMBER;
            }
            else if (newNum < 0)
            {
                newNum = 0;
            }
            int offset = newNum - girdNum;
            if (offset > 0) {
                for (int i = 0; i < offset; i++)
                {
                    girds.Add(Instantiate(gird, girdPanel.transform));
                }
            }
            else if (offset < 0) {
                for(int i= 0; i < -offset; i++)
                {
                    GameObject gird = girds[girds.Count - 1];
                    girds.RemoveAt(girds.Count - 1);
                    Destroy(gird);
                }
            }
            girdNum = newNum;
        }
        get {
            return girdNum;
        }
    }
    public void numChange(int offset)
    {
        Debug.Log("numchange 收到offset:" + offset);
        GirdNumber += offset;
    }
    public void startRoll() {
        foreach(GameObject obj in girds)
        {
            obj.GetComponent<energyGird>().randomColor();
        }
    }
}
