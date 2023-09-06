using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackOutPro : MonoBehaviour
{
    float alpha = 1f;
    Image image;

    bool isFadeIn = true;
    bool isFadeOut = false;

    float num;

    void Start()
    {
        image = GetComponent<Image>();
        num = 0.015625f;
    }

    private void Update()
    {
        if (Input.GetKeyDown("joystick button 1"))
        {
            Debug.Log("");
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
