using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPointCoutrol : MonoBehaviour
{
    public GameObject Player2;
    public float Speed = 0;   // プレイヤー移動速度

    public bool JumpFlag = false;
    public bool GroundFlag = false;
    public bool TurnFlag = true;

    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(Player2.transform.position.x / 20+1550, 12, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        pos.x = Player2.transform.position.x / 20+1550;
        transform.localPosition = pos;
    }
}
