using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BulletMove2 : MonoBehaviour
{
    Vector3 Move;
    Vector3 Pos;
    Vector3 press;

    playerLifeCount Script_B;

    int timer;
    int lasttimer;
    float RandPos;

    [SerializeField] AudioSource Charge;
    [SerializeField] AudioSource Shot;

    GameObject player;
    public string Player2;
    public string targetObjectName;
    public string hideObjectName;



    public bool flipFlag;
    public bool moveFlag;



    void Start()
    {
        this.Script_B = FindObjectOfType<playerLifeCount>(); //スクリプトを探して上宣言した変数に代入。
        int a = Script_B.countProperty; // スクリプトAから変数を持ってくる。（get）

        Charge.Play();

        player = GameObject.Find(Player2);
        flipFlag = player.GetComponent<Player2Control>().TurnFlag;
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
        if (timer == 60)
        {
            Debug.Log("na-zena-ze");
            Shot.Play();
        }
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
            lasttimer = 200;
            
            GameObject targetObject = GameObject.Find(targetObjectName);    // 名前を設定

            
            RandPos = Random.Range(0, 1000.0f);
            targetObject.gameObject.transform.Translate(RandPos-500, 10, 0);
            Script_B.countProperty -= 10;
        }

        


        //当たった対象がガードだった時
        if (collision.gameObject.name == hideObjectName)
        {
            GameObject hideObject = GameObject.Find(hideObjectName);    // 名前を設定
            Destroy(gameObject);                             // この判定をですとろい
        }
    }
}