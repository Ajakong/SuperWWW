using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COK : MonoBehaviour
{
    float RandPos;
    Vector3 reset;
    playerLifeCount Script_A;
    player2LifeCount Script_B;

    public string targetObjectName;
    public string hideObjectName;

    // Update is called once per frame
    void Start()
    {
        reset = Vector3.zero;
        this.Script_A = FindObjectOfType<playerLifeCount>(); //スクリプトを探して上宣言した変数に代入。
        int i = Script_A.countProperty; // スクリプトAから変数を持ってくる。（get）
        this.Script_B = FindObjectOfType<player2LifeCount>(); //スクリプトを探して上宣言した変数に代入。
        int a = Script_B.countProperty; // スクリプトAから変数を持ってくる。（get）
    }
    private void OnTriggerEnter2D(Collider2D collision)                 // 当たり判定を察知
    {
        // 当たった対象が敵プレイヤーだった時
        if (collision.gameObject.name == targetObjectName)
        {
            GameObject targetObject = GameObject.Find(targetObjectName);    // 名前を設定
            RandPos = Random.Range(0, 1000.0f);
            targetObject.gameObject.transform.Translate(RandPos - 500, 0, 0);
            if (collision.gameObject.name == "Player")
                Script_A.countProperty -= 1;
            if (collision.gameObject.name == "Player2")
            {
                Script_B.countProperty -= 1;
            }
        }



        //当たった対象がガードだった時
        if (collision.gameObject.name == hideObjectName)
        {
            GameObject hideObject = GameObject.Find(hideObjectName);    // 名前を設定
            this.transform.localPosition = reset;

            this.gameObject.SetActive(false);
        }
    }

}
