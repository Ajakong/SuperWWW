using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player2Life : MonoBehaviour
{
    public int lifeCount;
    // Start is called before the first frame update
    void Start()
    {
        lifeCount = 50;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = ("Å~") + lifeCount.ToString("0");
    }
}
