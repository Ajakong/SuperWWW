using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerControl : MonoBehaviour
{

   public GameObject Image;
        
    float countSecond = 0.49f;
    int countMinute = 5;

    public string Timer;

    int starttimer;

    // Start is called before the first frame update
    void Start()
    {
        starttimer = 0;
    }




    // Update is called once per frame
    void Update()
    {
        if (starttimer > 200)
        {
            countSecond -= Time.deltaTime;

            //countTimer -= Time.deltaTime;
            ////countTimer‚ð60‚ÅŠ„‚Á‚½‚à‚Ì‚ð•ª‚É“ü‚ê‚é‚±‚Æ‚Åint‚È‚Ì‚Å
            //countMinute = (int)(countTimer / 60f);

            //countSecond = (60f % countTimer);

            if (countSecond < -0.5000f)
            {
                countSecond = 59.49999f;
                countMinute += -1;
            }
        }
            GetComponent<Text>().text
                = countMinute.ToString("00") + ":" + countSecond.ToString("00");
            //Debug.Log(countSecond +" : "+ GetComponent<Text>().text);
        
        
    }
    private void FixedUpdate()
    {
        starttimer++;
    }
}
