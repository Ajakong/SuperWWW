using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exProCont : MonoBehaviour
{
    Vector3 localScale;
    Vector3 Move;
    GameObject bomb;
    Vector3 BombPos;
    player2LifeCount Script_A;
    playerLifeCount Script_B;

    int timer;
    float RandPos;
    

    public string targetObjectName;
    public string hideObjectName;
    public string Bomb;


    void Start()
    {
        bomb = GameObject.Find(Bomb);
        BombPos=new Vector3(bomb.transform.position.x, bomb.transform.position.y,bomb.transform.position.z);
        //BombPos = GetComponentInParent<Transform>().position;
        
        timer = 0;
        transform.position = BombPos;
        Move = new Vector3(0.1f, 0.1f, 0);

        this.Script_A = FindObjectOfType<player2LifeCount>(); //スクリプトを探して上宣言した変数に代入。
        int i = Script_A.countProperty; // スクリプトAから変数を持ってくる。（get）
        this.Script_B = FindObjectOfType<playerLifeCount>(); //スクリプトを探して上宣言した変数に代入。
        int a = Script_B.countProperty; // スクリプトAから変数を持ってくる。（get）



    }

    void Update()
    {



        if (timer == 1)
        {
            localScale = new Vector3(4, 4, 0);
        }
        else if (timer <= 40)
        {
            localScale += Move;
        }
        
        else if (timer > 40)
        {
            Destroy(gameObject);
        }


    }

    void FixedUpdate()
    {

        
        timer++;
    }

    private void OnTriggerEnter2D(Collider2D collision)                 // 当たり判定を察知
    {

        if (collision.gameObject.name == targetObjectName)
        {

            GameObject targetObject = GameObject.Find(targetObjectName);    // 名前を設定
            RandPos = Random.Range(0, 1000.0f);
            targetObject.gameObject.transform.Translate(RandPos - 500, 11, 0);
            if (collision.gameObject.name == "Player2")
            {
                Script_A.countProperty -= 5;
            }
            if (collision.gameObject.name == "Player")
            {
                Script_B.countProperty -= 5;
            }// 敵をですとろい
        }

    }
}
