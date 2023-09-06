using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordmove3 : MonoBehaviour
{
    // 剣攻撃
    int timer;
    float RandPos;
    Vector3 axis;       // 回転軸
    Vector3 point;
    Vector3 resetPos;
    Vector3 resetRot;
    Vector3 resetSca;
    playerLifeCount Script_A;
    player2LifeCount Script_B;

    public string targetObjectName;
    public string hideObjectName;
    public bool flipFlag;
    public float SpinLot;
    public float PrePoint;
    public float lotZ;



    void Start()
    {
        PrePoint = 0.5f;
        lotZ = 280.0f;
        SpinLot = 14.0f;
        resetPos = new Vector3(0, -PrePoint, 0);
        resetRot = new Vector3(0, 0, 60.0f);

        axis = new Vector3(0, 0, 2);

        timer = 0;

        this.Script_A = FindObjectOfType<playerLifeCount>(); //スクリプトを探して上宣言した変数に代入。
        int i = Script_A.countProperty; // スクリプトAから変数を持ってくる。（get）
        this.Script_B = FindObjectOfType<player2LifeCount>(); //スクリプトを探して上宣言した変数に代入。
        int a = Script_B.countProperty; // スクリプトAから変数を持ってくる。（get）

    }



    private void Update()
    {
        point = new Vector3(transform.parent.position.x + PrePoint, transform.parent.position.y, 0);
    }



    void FixedUpdate()
    {
        if (timer == 1)
        {
            // パンチ方向反転
            flipFlag = GetComponentInParent<Player2Control>().TurnFlag;
            if (flipFlag)
            {
                SpinLot = -12.0f;
                PrePoint = -1.5f;
                lotZ = -140.0f;
                this.transform.localRotation = Quaternion.Euler(0, 0, lotZ);
                this.transform.localPosition = resetPos;
            }
            if (!flipFlag)
            {
                SpinLot = 12.0f;
                PrePoint = 1.5f;
                lotZ = 140.0f;
                this.transform.localRotation = Quaternion.Euler(0, 0, lotZ);
                this.transform.localPosition = resetPos;
            }
        }



        if (timer < 16)
        {

            transform.RotateAround(point, axis, SpinLot);
        }
        else
        {
            transform.localPosition = resetPos;
            timer = 0;
            this.gameObject.SetActive(false);
        }
        timer++;
    }



    private void OnTriggerEnter2D(Collider2D collision)                 // 当たり判定を察知
    {
        // 当たった対象が敵プレイヤーだった時
        if (collision.gameObject.name == targetObjectName)
        {
            GameObject hideObject = GameObject.Find(targetObjectName);    // 名前を設定
            GameObject targetObject = GameObject.Find(targetObjectName);    // 名前を設定

            RandPos = Random.Range(70, 950.0f);
            Debug.Log(RandPos);
            targetObject.gameObject.transform.Translate(RandPos - 500.0f, 10, 0);

            Script_A.countProperty -= 10;
            if (collision.gameObject.name == "Player2")
            {
                Script_B.countProperty -= 1;
            }
        }



        // 当たった対象がガードだった時
        if (collision.gameObject.name == hideObjectName)
        {
            GameObject hideObject = GameObject.Find(hideObjectName);    // 名前を設定
            this.transform.localRotation = Quaternion.Euler(0, 0, 140.0f);
            this.transform.localPosition = resetPos;
            timer = 0;
            this.gameObject.SetActive(false);                             // この判定をですとろい
        }
    }
}
