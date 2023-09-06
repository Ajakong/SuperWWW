using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class enemyController : MonoBehaviour
{



    static Vector3 target;
    Vector3 EnePos;



    public float speed = 0;



    public bool TurnFlag;



    Rigidbody2D ebody;



    int Switch;





    void Start()
    {
        TurnFlag = false;
        Switch = GetComponent<enemyAttack>().WeponSwitch;
    }
    void FixedUpdate()
    {
        //êÈåæÇ»Ç«
        target = GameObject.Find("Player").transform.position;
        ebody = GetComponent<Rigidbody2D>();
        ebody.gravityScale = 1;
        ebody.constraints = RigidbodyConstraints2D.FreezeRotation;
        EnePos = this.transform.position;



        float distance = Vector3.Distance(target, EnePos);
        if (distance < 20)
        {
            if (target.x > EnePos.x)
            {
                speed = 0.1f;
                TurnFlag = false;
            }



            if (target.x < EnePos.x)
            {



                speed = -0.1f;
                TurnFlag = true;
            }
            switch (Switch)
            {
                case 1:
                    if (Mathf.Abs(target.x - EnePos.x) < 3) speed = 0;
                    break;



                case 2:
                case 3:
                    if (Mathf.Abs(target.x - EnePos.x) < 8) speed = 0;
                    break;



                case 4:
                    if (Mathf.Abs(target.x - EnePos.x) < 20) speed = 0;
                    break;



                default:
                    break;
            }







        }



        transform.Translate(speed, 0, 0);



        speed = 0;







    }
}