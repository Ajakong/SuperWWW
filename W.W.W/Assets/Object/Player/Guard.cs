using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Guard : MonoBehaviour
{
    GameObject guard;
    public bool FragGuard;      // ˜A”­–hŽ~
    int CoolTimer;
    int AppTimer;
    public bool flipFlag;

    private void Start()
    {
        guard = GameObject.Find("GuardPre");
        guard.SetActive(false);
        FragGuard = true;
        CoolTimer = 0;
        AppTimer = 0;
    }

    private void Update()
    {
        flipFlag = GetComponentInParent<PlayerController>().TurnFlag;
        
        if (!flipFlag) guard.transform.localPosition = new Vector3(0.75f, 0, 0);
        if (flipFlag) guard.transform.localPosition = new Vector3(-0.75f, 0, 0);

        if (Input.GetKeyDown("joystick 1 button 0") && (FragGuard))
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
            if (CoolTimer > 75)
            {
                FragGuard = true;
            }
        }
    }
}
