using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boardPanel : MonoBehaviour {
    public InputField hpfield;
    public InputField cdfield;
    public chessBoard board; 
        
    public void AddMonsterFormLeft(int y)
    {
        int hp = int.Parse(hpfield.text);
        int cd = int.Parse(cdfield.text);
        board.addFromLeft(y, hp, cd);

    }
    public void AddMonsterFormRight(int y)
    {
        int hp = int.Parse(hpfield.text);
        int cd = int.Parse(cdfield.text);
        board.addFromRight(y, hp, cd);

    }
    
}
