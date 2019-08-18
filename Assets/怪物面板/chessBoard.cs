using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chessBoard : MonoBehaviour {
    public const int X = 5;
    public const int Y = 3;
    public monsterShow[] iconList;
    protected static monsterShow picked;
    public void resetBoard()
    {
        foreach(monsterShow monster in iconList)
        {
            monster.quit();
        }
        picked.onUnPicked();
        picked = null;
    }
    public void quitPicked()
    {
        if (picked != null && picked.live)
        {
            picked.quit();
            picked.onUnPicked();
            picked = null;
        }
    }
    public void hpPlus(int num)
    {
        if (picked!=null&& picked.live) {
            picked.HP += num;
        }
    }
    public void timePlus(int num)
    {
        if(picked!=null&& picked.live) {
            picked.CD += num;
        }
    }
    public void retraget() {
        if (picked != null && picked.live)
        {
            picked.Traget = Random.Range(1, 4);
        }
    }
    public static void retraget(int tno)
    {
        if (picked != null && picked.live)
        {
            picked.Traget = tno;
        }
    }
    public void allTimePlus(int num)
    {
        foreach (monsterShow monster in iconList) {
            if(monster.live)
                monster.CD += num;
        }
    }
    public static monsterShow pickedIcon
    {
        set
        {
            if(picked!=null)
                picked.onUnPicked();
            picked = value;
            picked.onPicked();
                }
        get
        {
            return picked;
                }
    }
    public monsterShow monster(int x,int y)
    {
        return iconList[X * y + x];
    }
	// Use this for initialization
    public void addFromLeft(int y, int hp,int cd)
    {
        int center = X / 2;
        Debug.Log("center:"+center);
        monsterShow root =monster(center, y);
        if (!root.live) {
            root.init(hp,cd);
            return;
        }
        for(int i = 1; i <= X / 2; i++)
        {
            var current = monster(center - i, y);
            if (!current.live)
            {
                current.init(hp, cd);
                return;
            }
            
        }
    }
    public void addFromRight(int y, int hp, int cd)
    {
        int center = X / 2 ;
        monsterShow root = monster(center, y);
        if (!root.live)
        {
            root.init(hp, cd);
            return;
        }
        for (int i = 1; i <= X / 2; i++)
        {
            var current = monster(center + i, y);
            if (!current.live)
            {
                current.init(hp, cd);
                return;
            }
            
        }
    }
    public void addInRow(int y,int hp,int cd)
    {
        for (int x = 0; x < X; x++) {
            if (!monster(x,y).live)
            {
                iconList[X * y + x].init(hp, cd);
                break;
            }
        }
    }
    public void refresh()
    {
        Debug.Log("refresh start!");
        for (int y = 0; y < Y; y++)
        {
            //Debug.Log("y=" + y);
            for(int x=0;x<X;x++)
            {
                if (!monster(x, y).live) {
                    //Debug.Log("x=" + x + "monster not live");
                    for (int i = x+1; i < X; i++)
                    {
                        if (monster(i, y).live)
                        {
                            int hp_num = monster(i, y).HP;
                            int cd_num = monster(i, y).CD;
                            int t_num = monster(i, y).Traget;
                            monster(x,y).init(hp_num, cd_num);
                            monster(x, y).Traget = monster(i, y).Traget;
                            monster(i, y).quit();
                            break;
                        }
                    }
                }
            }
        }
    }
}
