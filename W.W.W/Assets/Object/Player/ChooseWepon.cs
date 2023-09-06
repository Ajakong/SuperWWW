using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseWepon : MonoBehaviour
{
    public Vector3 Pos;
    GameObject Fist;
    GameObject Sword;
    GameObject Madan;
    GameObject Kamehame;
    GameObject Bomb;

    GameObject Player;
    int WeponC;
    int WeponHave;
    Panch p;

    void Start()
    {
        Fist=GameObject.Find("Fist");
        Madan=GameObject.Find("scroll");
        Sword=GameObject.Find("Sword");
        Kamehame=GameObject.Find("maheroSoul");
        Bomb=GameObject.Find("Bom");
        Fist.SetActive(false);
        Sword.SetActive(false);
        Madan.SetActive(false);
        Kamehame.SetActive(false);
        Bomb.SetActive(false);

        Player = GameObject.Find("Player");
        Pos = new Vector3(0, 37.5f, 0);

        
    }

    // Update is called once per frame
    void Update()
    {
            p = Player.GetComponent<Panch>();
            WeponC = p.WeponC;
            WeponHave = p.WeponSwitch;
            if(WeponC == 0)
            {
                Pos.x = -1564;
            }
            if (WeponC == 1)
            {
                Pos.x = -1550;
            }
            if(WeponC == 2)
            {
                Pos.x = -1536;
            }

            if(WeponHave==0)
        {
            Fist.SetActive(true);
            Sword.SetActive(false);
            Madan.SetActive(false);
            Kamehame.SetActive(false);
            Bomb.SetActive(false);
        }
            if(WeponHave==1)
        {
            Fist.SetActive(false);
            Sword.SetActive(true);
            Madan.SetActive(false);
            Kamehame.SetActive(false);
            Bomb.SetActive(false);
        }
        if (WeponHave == 2)
        {
            Fist.SetActive(false);
            Sword.SetActive(false);
            
            Madan.SetActive(true);
            Kamehame.SetActive(false);
            Bomb.SetActive(false);
        }
        if (WeponHave == 3)
        {
            Fist.SetActive(false);
            Sword.SetActive(false);
            Madan.SetActive(false);
            Kamehame.SetActive(true);
            Bomb.SetActive(false);
        }
        if (WeponHave == 4)
        {
            Fist.SetActive(false);
            Sword.SetActive(false);
            Madan.SetActive(false);
            Kamehame.SetActive(false);
            Bomb.SetActive(true);
        }
        this.transform.position = Pos;
    }
}
