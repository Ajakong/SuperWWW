using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alerm : MonoBehaviour
{
    public GameObject Image;
    public float alarm = 300;
    // Start is called before the first frame update
    void Start()
    {

        Image.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        alarm -= Time.deltaTime;

        if (alarm < 0)
        {

            Image.SetActive(true);
            
        }
    }
}
