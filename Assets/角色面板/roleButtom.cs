using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roleButtom : MonoBehaviour {
    public InputField ifield;
    public rolePanel panel;
    public void onClick() {
        int num;
        if (int.TryParse(ifield.text, out num)) {
            panel.setActiveNum(num);
        }

    }
}
