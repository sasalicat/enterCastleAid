using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class retragetButtom : MonoBehaviour {
    public InputField inpf;
    public void onClick()
    {
        int no;
        if (int.TryParse(inpf.text, out no)) {
            chessBoard.retraget(no);
        }

    }

}
