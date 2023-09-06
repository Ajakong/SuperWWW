using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Guard2 : MonoBehaviour
{
    GameObject guard;
    Vector3 voidWall;
    public bool FragGuard;      // ˜A”­–hŽ~
    int CoolTimer;
    int AppTimer;
    public bool flipFlag;

    private void Start()
    {
        guard = GameObject.Find("GuardPre2");
        guard.SetActive(false);
        FragGuard = true;
        CoolTimer = 0;
        AppTimer = 0;
        voidWall = new Vector3(0, 0.02f, 0);
    }

    private void Update()
    {
        flipFlag = GetComponentInParent<Player2Control>().TurnFlag;
        
        if (!flipFlag) guard.transform.localPosition = new Vector3(0.75f, 0, 0);
        if (flipFlag)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            guard.transform.localPosition = new Vector3(-0.75f, 0, 0);
        }

        if ((Input.GetKeyDown("joystick 2 button 0")) && (FragGuard))
        {
            FragGuard = false;
            //ƒK[ƒh‚Ì”­¶
            guard.SetActive(true);
            AppTimer = 0;
            CoolTimer = 0;
        }
        
        if (AppTimer > 25)
        {
            guard.SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        
        if (!FragGuard)
        {
            CoolTimer++;
            AppTimer++;
            if (AppTimer < 25)
            {
                guard.transform.localPosition += voidWall;
            }
            if (CoolTimer > 75)
            {
                FragGuard = true;
            }
        }
    }
}
