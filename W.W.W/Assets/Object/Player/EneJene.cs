using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneJene : MonoBehaviour
{
    int[] randpos = new int[4];
    int no = 0;
    bool[] isGetNum = new bool[4] { false, false, false, false};

    public void Start()
    {

        DropWepon playerscript; //呼ぶスクリプトにあだなつける

        while (no < 4)
        {
            randpos[no] = Random.Range(0, 4);
            if (!isGetNum[randpos[no]])
            {
                isGetNum[randpos[no]] = true;
                no++;
            }
        }

        GameObject obj = GameObject.Find("Enemy0"); //Playerっていうオブジェクトを探す
        playerscript = obj.GetComponent<DropWepon>(); //付いているスクリプトを取得
        playerscript.WeponNum = randpos[0];

        obj = GameObject.Find("Enemy1"); //Playerっていうオブジェクトを探す
        playerscript = obj.GetComponent<DropWepon>(); //付いているスクリプトを取得
        playerscript.WeponNum = randpos[1];

        obj = GameObject.Find("Enemy2"); //Playerっていうオブジェクトを探す
        playerscript = obj.GetComponent<DropWepon>(); //付いているスクリプトを取得
        playerscript.WeponNum = randpos[2];

        obj = GameObject.Find("Enemy3"); //Playerっていうオブジェクトを探す
        playerscript = obj.GetComponent<DropWepon>(); //付いているスクリプトを取得
        playerscript.WeponNum = randpos[3];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
