using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSound: MonoBehaviour
{
    int timer;



    [SerializeField] AudioSource BGM;
    [SerializeField] AudioSource Count;
    [SerializeField] AudioSource GameStart;



    void Start()
    {
        timer = 0;
    }



    private void FixedUpdate()
    {
        timer++;
    }



    void Update()
    {
        if ((timer == 60) || (timer == 120) || (timer == 180))
        {
            Count.Play();
        }



        if (timer == 240)
        {
            GameStart.Play();
        }



        if (timer == 270)
        {
            BGM.Play();
        }
    }
}
