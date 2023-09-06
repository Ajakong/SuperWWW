using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class enemyAttack : MonoBehaviour
{
    GameObject sword;
    GameObject kamehameha;
    public GameObject bomb;



    GameObject Player;



    public GameObject bullet;
    public string GuardPre;



    public bool FragAttack = true;      // çUåÇíÜÇÃçUåÇÇñhé~
    public int WeponSwitch;
    int CoolTimer;
    int DelayTimer;



    // Start is called before the first frame update
    void Start()
    {
        CoolTimer = 0;
        sword = GameObject.Find("eSword");
        kamehameha = GameObject.Find("eKamehame");



        Player = GameObject.Find("Player");



        DelayTimer = 0;



        sword.SetActive(false);
        kamehameha.SetActive(false);
    }



    // Update is called once per frame
    private void Update()
    {
        if ((Mathf.Abs(this.transform.position.x - Player.transform.position.x) < 3) && (FragAttack))
        {
            
            if (WeponSwitch == 1)
            {
                if (DelayTimer >= 120)
                {
                    FragAttack = false;
                    sword.SetActive(true);
                    CoolTimer = 0;
                    DelayTimer = 0;
                }
            }
        }
        if ((Mathf.Abs(this.transform.position.x - Player.transform.position.x) < 8) && (FragAttack))
        {
            if (WeponSwitch == 2)
            {
                if (DelayTimer >= 120)
                {
                    FragAttack = false;
                    Instantiate(bullet);
                    CoolTimer = 0;
                    DelayTimer = 0;
                }
            }
            if (WeponSwitch == 3)
            {
                if (DelayTimer >= 120)
                {
                    FragAttack = false;
                    kamehameha.SetActive(true);
                    CoolTimer = 0;
                    DelayTimer = 0;
                }
            }
        }
        if ((Mathf.Abs(this.transform.position.x - Player.transform.position.x) < 20) && (FragAttack))
        {
           
            if (WeponSwitch == 4)
            {
                if (DelayTimer >= 120)
                {
                    FragAttack = false;
                    Instantiate(bomb);
                    CoolTimer = 0;
                    DelayTimer = 0;
                }
            }
        }
    }



    // éüìÆçÏÇ‹Ç≈ÇÃë“Çøéûä‘
    private void FixedUpdate()
    {
        DelayTimer++;
        if (!FragAttack)
        {
            CoolTimer += 2;
            if (WeponSwitch == 1) CoolTimer += 2;
            if (WeponSwitch == 2) CoolTimer--;
            if (WeponSwitch == 3) CoolTimer++;
            if (CoolTimer > 300)
            {
                FragAttack = true;
            }
        }



    }
}