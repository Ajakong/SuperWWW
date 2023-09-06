using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class eBombMove : MonoBehaviour
{
    Vector3 Move;
    Vector3 Pos;
    Vector3 Reset;
    Vector3 zero;
    int timer;
    float RandPos;





    public GameObject exPro;
    GameObject enemy;
    GameObject BombPos;
    Rigidbody2D Rig;
    public string Player;





    public bool BombFlag;
    public bool flipFlag;
    public bool moveFlag;





    void Start()
    {
        Rig = GetComponent<Rigidbody2D>();
        Rig.gravityScale = 5;









        BombFlag = false;
        Reset = new Vector3(0.6f, -1f, 0);
        zero = Vector3.zero;
        enemy = GameObject.Find(Player);
        flipFlag = enemy.GetComponent<enemyController>().TurnFlag;
        if (flipFlag)
        {
            Pos = new Vector3(enemy.transform.position.x - 0.3f, enemy.transform.position.y - 0.15f, enemy.transform.position.z);
            Move = new Vector3(-0.6f, 0.5f, 0);
        }
        if (!flipFlag)
        {
            Pos = new Vector3(enemy.transform.position.x + 0.3f, enemy.transform.position.y - 0.15f, enemy.transform.position.z);
            Move = new Vector3(0.6f, 0.5f, 0);
        }
        transform.position = Pos;





        timer = 0;
    }









    private void FixedUpdate()
    {
        if (timer < 5)
        {



            this.gameObject.transform.position += Move;
        }
        else if (this.gameObject.transform.position.y < 0)
        {
            Move = zero;
        }



    }





    private void OnTriggerEnter2D(Collider2D collision)                 // “–‚½‚è”»’è‚ðŽ@’m
    {
        BombFlag = true;



        if (collision.gameObject.name == Player)
        {
            BombFlag = false;
        }
        if (BombFlag == true)
        {



            BombPos = Instantiate(exPro);
            BombPos.name = "Bomb";
            Destroy(this.gameObject);
        }
    }
}