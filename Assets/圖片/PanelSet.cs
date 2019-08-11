using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSet : MonoBehaviour {
    public GameObject[] panels;
    public void SwitchPanel(int index)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            if (i != index)
            {
                panels[i].SetActive(false);
            }
            else {
                panels[i].SetActive(true);
            }
        }
    }
}
