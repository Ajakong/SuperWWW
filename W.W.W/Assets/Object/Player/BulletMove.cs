using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BulletMove : MonoBehaviour
{
    Vector3 Move;
    Vector3 Pos;
    Vector3 press;
    int timer;
    float RandPos;
    int life;

    player2LifeCount Script_A;

    [SerializeField] AudioSource Charge;
    [SerializeField] AudioSource Shot;

    GameObject player;
    public string Player;
    public string targetObjectName;
    public string hideObjectName;



    public bool flipFlag;
    public bool moveFlag;



    void Start()
    {
        this.Script_A = FindObjectOfType<player2LifeCount>(); //スクリプトを探して上宣言した変数に代入。
        int i = Script_A.countProperty; // スクリプトAから変数を持ってくる。（get）
    
    Charge.Play();

        player = GameObject.Find(Player);
        flipFlag = player.GetComponent<PlayerController>().TurnFlag;
        if (flipFlag)
        {
            Pos = new Vector3(player.transform.position.x - 0.3f, player.transform.position.y - 0.15f, player.transform.position.z);
            Move = new Vector3(-0.6f, 0, 0);
        }
        if (!flipFlag)
        {
            Pos = new Vector3(player.transform.position.x + 0.3f, player.transform.position.y - 0.15f, player.transform.position.z);
            Move = new Vector3(0.6f, 0, 0);
        }
        transform.position = Pos;

        press = transform.localScale;

        timer = 0;

    }



    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer == 60) Shot.Play();

        if (timer <= 60)
        {
            press.x -= 0.01f;
            press.y -= 0.01f;
            transform.localScale = press;
        }

        if (timer > 60)
        {
            transform.localPosition += Move;
            Charge.volume -= 0.05f;
            Shot.volume -= 0.035f;
            transform.localPosition += Move;
        }





        if (timer > 85)
        {
            Destroy(this.gameObject);
        }
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
            Script_A.countProperty -= 10;
        }



        //当たった対象がガードだった時
        if (collision.gameObject.name == hideObjectName)
        {
            GameObject hideObject = GameObject.Find(hideObjectName);    // 名前を設定
            Destroy(gameObject);                             // この判定をですとろい
        }
    }
}