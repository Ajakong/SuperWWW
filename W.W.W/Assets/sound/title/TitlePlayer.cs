using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlePlayer : MonoBehaviour
{
    bool turnFlag;



    [SerializeField] AudioSource mainB;
    [SerializeField] AudioSource backB;
    [SerializeField] AudioSource selectB;



    void Start()
    {
        mainB.Play();
        backB.Play();
    }





    void Update()
    {
        if (Input.GetKeyDown("joystick button 1"))
        {
            selectB.Play();
            turnFlag = true;
        }
        if (turnFlag)
        {
            mainB.volume -= 0.0005f;
            backB.volume -= 0.0005f;
        }
    }
}
