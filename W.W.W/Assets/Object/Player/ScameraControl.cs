using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScameraControl : MonoBehaviour
{
    GameObject player2;
    
    // Start is called before the first frame update
    void Start()
    {
        
        this.player2 = GameObject.Find("Player2");
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 Player2Pos = this.player2.transform.position;
        if ((player2.transform.position.x - transform.position.x > 5)&&(transform.position.x < 435))
        {


            transform.position = new Vector3(Player2Pos.x-5, transform.position.y, transform.position.z);
        }
        if ((player2.transform.position.x - transform.position.x < -5)&& (transform.position.x > -435))
        {
            transform.position = new Vector3(Player2Pos.x + 5, transform.position.y, transform.position.z);
        }
    }
    
}
