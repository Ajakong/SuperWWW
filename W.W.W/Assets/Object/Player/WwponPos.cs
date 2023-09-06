using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WwponPos : MonoBehaviour
{
    public Vector3 Pos;


    GameObject Player;
    int WeponC;
    int WeponHave;
    Panch p;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        Pos = new Vector3(0, 37.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        p = Player.GetComponent<Panch>();
        WeponC = p.WeponC;

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
            Pos.x = -1534;
        }
        this.transform.position = Pos;
    }
}
