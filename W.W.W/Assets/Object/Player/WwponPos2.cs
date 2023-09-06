using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WwponPos2 : MonoBehaviour
{
    public Vector3 Pos;


    GameObject Player;
    int WeponC;
    int WeponHave;
    Panch2 p;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player2");
        Pos = new Vector3(0, 37.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        p = Player.GetComponent<Panch2>();
        WeponC = p.WeponC;

        if (WeponC == 0)
        {
            Pos.x = 1534;
        }
        if (WeponC == 1)
        {
            Pos.x = 1550;
        }
        if (WeponC == 2)
        {
            Pos.x = 1564;
        }
        this.transform.position = Pos;
    }
}
