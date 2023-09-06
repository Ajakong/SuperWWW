using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    GameObject timer;

    public string Timer;

    float Alert;
    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find(Timer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
