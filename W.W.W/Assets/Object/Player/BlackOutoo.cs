using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackOutoo : MonoBehaviour
{
    float alpha = 1f;
    Image image;


    GameObject life1;
    GameObject life2;

    playerLifeCount act1;
    player2LifeCount act2;

    bool isFadeIn = true;
    bool isFadeOut = false;

    float num;
    bool active1;
    bool active2;

    void Start()
    {
        image = GetComponent<Image>();
        num = 0.015625f;
        life1 = GameObject.Find("playerLife");
        life2 = GameObject.Find("player2Life");
    }

    private void Update()
    {
        act1 = life1.GetComponent<playerLifeCount>();
        act2 = life2.GetComponent<player2LifeCount>();
        active1 = act1.active;
        active2 = act2.active;
        if (active1 == true)
        {
            isFadeOut = true;
        }
        if(active2==true)
        {
            isFadeOut = true;
        }

    }

    private void FixedUpdate()
    {
        if (isFadeIn)
        {
            if (alpha <= 0)
            {
                isFadeIn = false;
            }



            alpha -= 0.015625f;
            if (alpha <= 0) alpha = 0;
            image.color = new Color(0, 0, 0, alpha);


        }

        if (isFadeOut)
        {
            Debug.Log("OK");
            alpha += 0.015625f;
            if (1 <= alpha) alpha = 1;
            image.color = new Color(0, 0, 0, alpha);
        }
    }
}
