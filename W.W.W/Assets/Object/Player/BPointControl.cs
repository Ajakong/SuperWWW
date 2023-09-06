using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPointControl : MonoBehaviour
{
    public GameObject Player;
    public float Speed = 0;   // プレイヤー移動速度

    public bool JumpFlag = false;
    public bool GroundFlag = false;
    public bool TurnFlag = false;

    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(Player.transform.position.x / 20-1550, 15.8f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        pos.x = Player.transform.position.x / 20-1550;
        transform.localPosition = pos;
    }
}
