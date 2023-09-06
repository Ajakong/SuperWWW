using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardMove : MonoBehaviour
{
    int timer;  

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer > 25 )
        {
            
        }

        //タイマの更新
        timer++;
    }

    //private void OnTriggerEnter2D(Collider2D collision)                 // 当たり判定を察知
    //{
    //    // 当たった対象がガードだった時
    //    Destroy(collision.gameObject);                             // この判定をですとろい
    //}
}
