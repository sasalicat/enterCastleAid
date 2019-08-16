using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class monsterShow : MonoBehaviour {

    public bool live = false;
    protected int hp;
    protected int cd;
    protected int tno;
    public Image hpIcon;
    public Text hpText;
    public Image cdIcon;
    public Text cdText;
    public Image background;
    public Image traget;
    public Text tragetNo;
    public Color normalColor;
    public Color pickedColor;
    public int HP
    {
        set
        {
            if (value < 0)
            {
                hp = 0;
            }
            else
            {
                hp = value;
            }
            hpText.text = hp + "";

        }
        get
        {
            return hp;
        }
    }
    public int CD {
        set
        {
            if (value < 0)
            {
                cd = 0;
            }
            else
            {
                cd = value;
            }
            cdText.text = cd + "";
        }get
        {
            return cd;
        }
    }
    public int Traget
    {
        set {
            if (value > 0 && value <= 3) {
                tno = value;
            }
            tragetNo.text = tno + "";
        }
        get
        {
            return tno;
        }
    }
    public void quit() {

        hpIcon.gameObject.SetActive(false);
        cdIcon.gameObject.SetActive(false);
        traget.gameObject.SetActive(false);
        live = false;
    }
    public void init(int hp,int cd)
    {
        this.hp = hp;
        hpIcon.gameObject.SetActive(true);
        hpText.text = hp + "";

        this.cd = cd;
        cdIcon.gameObject.SetActive(true);
        cdText.text = cd + "";
        live = true;

        this.tno = Random.Range(1,4);
        traget.gameObject.SetActive(true);
        tragetNo.text = tno+"";
    }
    public void onPicked()
    {
        background.color = pickedColor;
    }
    public void onUnPicked() {
        background.color = normalColor;
    }
    public void onClick() {
        Debug.Log("onClick 被觸發");
        chessBoard.pickedIcon = this;
    }
}
