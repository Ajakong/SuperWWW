using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;



public class PlayerController : MonoBehaviour
{

    float RandPos;

    int weponFlag;
    public float Speed = 0;   // プレイヤー移動速度
    public float Jump = 0;   //ジャンプのパワー

    Rigidbody2D rbody;
    GameObject player;
    GameObject Kamehame;
    GameObject Sword;
    private Animator anim = null;

    [SerializeField] AudioSource Dash;
    [SerializeField] AudioSource jump;


    public bool KamehameFlag;
    public bool swordFlag;

    public string targetObjectName;

    float hori;


    public bool JumpFlag = false;
    public bool GroundFlag = true;
    public bool TurnFlag = false;

    int starttimer;

    void Start()
    {
        swordFlag = false;
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 5;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        Kamehame = GameObject.Find("Player");
        starttimer = 0;
    }



    async void Update()
    {
        //hori = Input.GetAxis("Horiz");  // Lスティック横軸　（左-1～右1）
        // スペースキーでジャンプ
        if (Input.GetKeyDown(KeyCode.W) && (GroundFlag))
        {
            await Task.Delay(10);
            JumpFlag = true;
        }
        if (!GroundFlag)
        {
            Jump = 0;
        }
        
        if (hori != 0)
        {
            Dash.volume = 1;
        }
        if ((hori == 0) || (transform.position.y > -1.9))
        {
            Dash.volume = 0;
        }

        if (transform.position.y < -1.9) jump.Play();
    }



    void FixedUpdate()
    {
        starttimer++;

        if(starttimer > 280)
        {
            if(starttimer == 281) Dash.Play();
            Debug.Log(GroundFlag);
            if (JumpFlag)
            {
                Jump += 3.0f;
                transform.Translate(0, Jump, 0);
                JumpFlag = false;
            }




            weponFlag = GetComponent<Panch>().WeponSwitch;

            // 右矢印で右移動
            if (Input.GetKey(KeyCode.D))
            {
                KamehameFlag = Kamehame.GetComponent<Panch>().kameFlag;
                //swordFlag = Sword.GetComponent<Panch>().SwordFlag;
                Speed += 0.5f;
                TurnFlag = false;

                if (weponFlag == 0)
                {
                    Speed += 0.2f;
                }
                if (weponFlag == 1)
                {
                    Speed += 0.1f;
                }

                if (this.gameObject.transform.position.x > 450.0f)
                {
                    Speed = 0.0f;
                }

            }

            // 左矢印で左移動

            if (Input.GetKey(KeyCode.A))
            {

                KamehameFlag = Kamehame.GetComponent<Panch>().kameFlag;
                //swordFlag = Sword.GetComponent<Panch>().SwordFlag;

                Speed += -0.5f;
                TurnFlag = true;

                if (weponFlag == 0)
                {
                    Speed -= 0.2f;
                }
                if (weponFlag == 1)
                {
                    Speed -= 0.1f;
                }

                if (this.gameObject.transform.position.x < -450.0f)
                {
                    Speed = 0.0f;
                }



            }
            if (KamehameFlag == true)
            {
                Speed = 0;


            }
            //if (swordFlag == true)
            //{
            //    Speed = 0;


            //}

            if (this.gameObject.transform.position.y < -100)
            {
                Transform myTransform = this.transform;
                Vector3 pos = myTransform.position;
                pos.x = 0;
                pos.y = 0;
                pos.z = 0;
                myTransform.position = pos;

                RandPos = Random.Range(0, 1000.0f);
                this.gameObject.transform.Translate(RandPos - 500, 5, 0);
            }

            if (Speed != 0)
            {
                anim.SetBool("Run", true);
            }
            else
            {
                anim.SetBool("Run", false);
            }

            transform.Translate(Speed, 0, 0);
            this.GetComponent<SpriteRenderer>().flipX = TurnFlag;
            Speed = 0;


        }

    }



    private void OnTriggerStay2D(Collider2D collision)
    {
        GroundFlag = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GroundFlag = false;
    }
}