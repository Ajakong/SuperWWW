using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;



public class CircleMove : MonoBehaviour
{
    Vector3 Move;
    Vector3 reset;
    player2LifeCount Script_A;
    playerLifeCount Script_B;
    int timer;
    float RandPos;



    public string targetObjectName;
    public string hideObjectName;
    public bool flipFlag;



    // Start is called before the first frame update
    void Start()
    {
        reset = Vector3.zero;
        this.transform.localPosition = reset;
        Move = new Vector3(0.1f, 0, 0);
        this.Script_A = FindObjectOfType<player2LifeCount>(); //スクリプトを探して上宣言した変数に代入。
        int i = Script_A.countProperty; // スクリプトAから変数を持ってくる。（get）
        this.Script_B = FindObjectOfType<playerLifeCount>(); //スクリプトを探して上宣言した変数に代入。
        int a = Script_B.countProperty; // スクリプトAから変数を持ってくる。（get）


        timer = 0;
    }



    private void Update()
    {
        // パンチ方向反転
        flipFlag = GetComponentInParent<PlayerController>().TurnFlag;
    }



    //1/50ごとにここを通る。
    private void FixedUpdate()
    {
        if (timer == 1)
        {
            if (flipFlag) Move.x = -0.1f;
            if (!flipFlag) Move.x = 0.1f;
        }
        // 殴り始め
        if (timer < 10)
        {
            transform.localPosition += Move;   // 10フレームで殴りきる
        }
        else if (timer < 20)//手を引っ込め始める



        {
            transform.localPosition -= Move;   // 10フレームで戻しきる
        }
        else
        {
            transform.localPosition = reset;
            timer = 0;
            this.gameObject.SetActive(false);
        }



        //タイマの更新
        timer++;
    }



    private void OnTriggerEnter2D(Collider2D collision)                 // 当たり判定を察知
    {
        // 当たった対象が敵プレイヤーだった時
        if (collision.gameObject.name == targetObjectName)
        {
            GameObject targetObject = GameObject.Find(targetObjectName);    // 名前を設定
            RandPos = Random.Range(0, 1000.0f);
            targetObject.gameObject.transform.Translate(RandPos-500, 10, 0);
            if (collision.gameObject.name == "Player2")
            {
                Script_A.countProperty -= 10;
            }
            if (collision.gameObject.name == "Player")
            {
                Script_B.countProperty -= 10;
            }
        }



        //当たった対象がガードだった時
        if (collision.gameObject.name == hideObjectName)
        {
            GameObject hideObject = GameObject.Find(hideObjectName);    // 名前を設定
            this.transform.localPosition = reset;
            timer = 0;
            this.gameObject.SetActive(false);
        }
    }
}