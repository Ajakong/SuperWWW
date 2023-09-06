using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoWep2 : MonoBehaviour
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
    Panch2 p;

    void Start()
    {
        Fist = GameObject.Find("Fist2");
        Madan = GameObject.Find("scroll2");
        Sword = GameObject.Find("Sword2");
        Kamehame = GameObject.Find("maheroSoul2");
        Bomb = GameObject.Find("Bom2");
        Fist.SetActive(false);
        Sword.SetActive(false);
        Madan.SetActive(false);
        Kamehame.SetActive(false);
        Bomb.SetActive(false);

        Player = GameObject.Find("Player2");
        Pos = new Vector3(0, 37.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        p = Player.GetComponent<Panch2>();
        WeponC = p.WeponC;
        WeponHave = p.WeponSwitch;
        if (WeponC == 0)
        {
            Pos.x = -1564;
        }
        if (WeponC == 1)
        {
            Pos.x = -1550;
        }
        if (WeponC == 2)
        {
            Pos.x = -1520;
        }

        if (WeponHave == 0)
        {
            Fist.SetActive(true);
            Sword.SetActive(false);
            Madan.SetActive(false);
            Kamehame.SetActive(false);
            Bomb.SetActive(false);
        }
        if (WeponHave == 1)
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
