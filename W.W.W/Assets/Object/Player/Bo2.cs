using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bo2 : MonoBehaviour
{
    Vector3 Move;
    Vector3 Pos;
    Vector3 Reset;
    Vector3 zero;
    int timer;
    float RandPos;

    public GameObject exPro;
    GameObject player;
    GameObject BombPos;
    Rigidbody2D Rig;
    public string Player;
    public string eSword;

    public bool BombFlag;
    public bool flipFlag;
    public bool moveFlag;

    void Start()
    {
        Rig = GetComponent<Rigidbody2D>();
        Rig.gravityScale = 5;



        BombFlag = false;
        Reset = new Vector3(0.6f, -1f, 0);
        zero = new Vector3(0, 0, 0);
        player = GameObject.Find(Player);
        flipFlag = player.GetComponent<Player2Control>().TurnFlag;
        if (flipFlag)
        {
            Pos = new Vector3(player.transform.position.x - 0.3f, player.transform.position.y - 0.15f, player.transform.position.z);
            Move = new Vector3(-0.3f, 0.5f, 0);
        }
        if (!flipFlag)
        {
            Pos = new Vector3(player.transform.position.x + 0.3f, player.transform.position.y - 0.15f, player.transform.position.z);
            Move = new Vector3(0.3f, 0.5f, 0);
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

        if (collision.gameObject.name != Player)
        {
            BombPos = Instantiate(exPro);
            //BombPos.name = "exPro";
            Destroy(gameObject);
            BombFlag = false;
        }
        if (collision.gameObject.name == eSword)
        {
            BombFlag = false;
        }
        if (BombFlag == true)
        {


        }
    }
}
