using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player");
    }  

    // Update is called once per frame
    void Update()
    {

        Vector3 PlayerPos = this.player.transform.position;
        if ((player.transform.position.x - transform.position.x > 5)&& (transform.position.x < 435))
        {


            transform.position = new Vector3(PlayerPos.x - 5, transform.position.y, transform.position.z);
        }
        if ((player.transform.position.x - transform.position.x < -5) && (transform.position.x > -435))
        {
            transform.position = new Vector3(PlayerPos.x + 5, transform.position.y, transform.position.z);
        }
    }
}
