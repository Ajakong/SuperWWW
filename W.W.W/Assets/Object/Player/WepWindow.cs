using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WepWindow : MonoBehaviour
{
    [SerializeField] Sprite SS;
    [SerializeField] Sprite MM;
    [SerializeField] Sprite KK;
    [SerializeField] Sprite BB;

    GameObject Player;
    GameObject Wepon;

    public string player;
    public string script;

    int Wepon1;
    int Wepon2;

    Panch p;
    Panch2 p2;

    SpriteRenderer Wep;


    void Start()
    {
        Wepon = this.gameObject;
        //Wep = Wepon.GetComponent<SpriteRenderer>;
        Player = GameObject.Find(player);
    }

    // Update is called once per frame
    void Update()
    {
        if (player == "Player")
        {
            p = Player.GetComponent<Panch>();
            Wepon1 = p.Wepon1;
            Wepon2 = p.Wepon2;
        }
        if (player == "Player2")
        {
            p2 = Player.GetComponent<Panch2>();
            Wepon1 = p2.Wepon1;
            Wepon2 = p2.Wepon2;
        }

        Wep.sprite = SS;
    }
}
