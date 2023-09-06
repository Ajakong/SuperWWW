using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
    [SerializeField] GameObject Fade;

    int timer;
    int timerMove;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        timerMove = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            timerMove = 1;
            
           
        }
        if(timer==120)
        {
            SceneManager.LoadScene("tuto" +
               "rial");
        }
    }
    private void FixedUpdate()
    {
        timer += timerMove;
    }
}
