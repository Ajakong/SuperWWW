using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class eBulletMove : MonoBehaviour
{
    Vector3 Move;
    Vector3 Pos;
    int timer;
    float RandPos;





    GameObject player;
    public string Enemy;
    public string targetObjectName;
    public string hideObjectName;





    public bool flipFlag;
    public bool moveFlag;





    void Start()
    {
        player = GameObject.Find(Enemy);
        flipFlag = player.GetComponent<enemyController>().TurnFlag;
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





        timer = 0;
    }





    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer > 60) transform.localPosition += Move;





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
            targetObject.gameObject.transform.Translate(RandPos - 500, 0, 0);
        }





        //当たった対象がガードだった時
        if (collision.gameObject.name == hideObjectName)
        {
            GameObject hideObject = GameObject.Find(hideObjectName);    // 名前を設定
            Destroy(gameObject);                             // この判定をですとろい
        }
    }
}