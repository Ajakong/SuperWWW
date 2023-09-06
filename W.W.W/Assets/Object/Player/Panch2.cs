using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Panch2 : MonoBehaviour
{
    GameObject punch;
    GameObject sword;
    GameObject kamehameha;

    GameObject Bomber;
    public GameObject bullet;
    public GameObject bomb;
    public string GuardPre;

    public float speed;
    public float gravity;

    public bool FragAttack = true;      // çUåÇíÜÇÃçUåÇÇñhé~
    public int WeponSwitch;

    public bool kameFlag;

    public bool SwordFlag;

    int WeponSwitchMax;
    int CoolTimer;

    int Wepon0;
    public int Wepon1;
    public int Wepon2;

    public int WeponC;

    // Start is called before the first frame update
    void Start()
    {
        WeponSwitch = 0;
        WeponC = 0;
        WeponSwitchMax = 4;
        CoolTimer = 0;
        punch = GameObject.Find("Circlepre2");
        sword = GameObject.Find("Sword2");
        kamehameha = GameObject.Find("Kamehame2");

        Wepon0 = 0;
        Wepon1 = 0;
        Wepon2 = 0;

        kameFlag = false;
        SwordFlag = false;
        punch.SetActive(false);
        sword.SetActive(false);
        kamehameha.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            switch (WeponC)
            {
                case 0:
                    {
                        Debug.Log("C0");
                        if (Wepon1 != 0)
                        {
                            Debug.Log("W1ok");
                            WeponSwitch = Wepon1;
                            WeponC = 1;
                        }
                        break;
                    }

                case 1:
                    {
                        Debug.Log("C1");
                        if (Wepon2 != 0)
                        {
                            WeponSwitch = Wepon2;
                            WeponC = 2;
                        }
                        else
                        {
                            WeponSwitch = Wepon0;
                            WeponC = 0;
                        }
                        break;
                    }

                case 2:
                    {
                        Debug.Log("C2");
                        WeponSwitch = Wepon0;
                        WeponC = 0;
                        break;
                    }

                default:
                    {
                        Debug.Log("df");
                        break;
                    }
            }
            Debug.Log(Wepon1);
            Debug.Log(WeponSwitch);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && (FragAttack))
        {
            switch (WeponSwitch)
            {
                case 0:
                    {
                        FragAttack = false;
                        punch.SetActive(true);
                        CoolTimer = 0;
                        break;
                    }
                case 1:
                    {
                        FragAttack = false;
                        sword.SetActive(true);
                        CoolTimer = 0;
                        SwordFlag = true;
                        break;
                    }
                case 2:
                    {
                        FragAttack = false;
                        Instantiate(bullet);
                        CoolTimer = 0;
                        break;
                    }
                case 3:
                    {
                        FragAttack = false;
                        kamehameha.SetActive(true);
                       
                        CoolTimer = 0;
                        kameFlag = true;
                        break;
                    }
                case 4:
                    {
                        FragAttack = false;
                        Bomber = Instantiate(bomb);
                        Bomber.name = "Bomb 2";
                        CoolTimer = 0;
                        break;
                    }
                default: break;
            }
        }
    }

    // éüìÆçÏÇ‹Ç≈ÇÃë“Çøéûä‘
    private void FixedUpdate()
    {
        if (!FragAttack)
        {
            kameFlag = false;
            SwordFlag = false;
            CoolTimer += 2;
            if (WeponSwitch == 1) CoolTimer += 2;
            if (WeponSwitch == 2) CoolTimer--;
            if (WeponSwitch == 3) CoolTimer--;
            if (WeponSwitch == 4) CoolTimer += 2;
            if (CoolTimer > 100)
            {
                FragAttack = true;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ìñÇΩÇ¡ÇΩëŒè€Ç™äeïêäÌÇæÇ¡ÇΩéû
        if (collision.gameObject.name == "SS")
        {
            if (Wepon1 == 0) Wepon1 = 1;
            else if (Wepon2 == 0)
            {
                if (Wepon1 != 1)
                {
                    Wepon2 = 1;
                }
            }
        }

        if (collision.gameObject.name == "MM")
        {
            if (Wepon1 == 0) Wepon1 = 2;
            else if (Wepon2 == 0)
            {
                if (Wepon1 != 2)
                {
                    Wepon2 = 2;
                }
            }
        }

        if (collision.gameObject.name == "KK")
        {
            if (Wepon1 == 0) Wepon1 = 3;
            else if (Wepon2 == 0)
            {
                if (Wepon1 != 3)
                {
                    Wepon2 = 3;
                }
            }
        }

        if (collision.gameObject.name == "BB")
        {
            if (Wepon1 == 0) Wepon1 = 4;
            else if (Wepon2 == 0)
            {
                if (Wepon1 != 4)
                {
                    Wepon2 = 4;
                }
            }
        }
    }
}
