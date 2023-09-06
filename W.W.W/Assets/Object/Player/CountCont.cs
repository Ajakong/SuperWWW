using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountCont : MonoBehaviour
{
    public GameObject count1;
    public GameObject count2;
    public GameObject count3;

    int starttimer;
    // Start is called before the first frame update
    void Start()
    {
        count1.SetActive(false);
        count2.SetActive(false);
        count3.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(starttimer==93)
        {
            count3.SetActive(false);
            count2.SetActive(true);
        }
        if (starttimer == 177)
        {
            count2.SetActive(false);
            count1.SetActive(true);
        }
        if (starttimer == 250)
        {
            count1.SetActive(false);
        }

    }
    private void FixedUpdate()
    {
        starttimer++;
    }


}
