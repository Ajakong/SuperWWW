using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player2LifeCount : MonoBehaviour
{
    public int lifeCount;
    public bool active;
    int timer;
    public GameObject Life;
    public GameObject fin;

    public GameObject Player1Win;
    public GameObject Player1Win2;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        lifeCount = 50;
        active = false;
        Life.SetActive(false);
        fin.SetActive(false);
        Player1Win.SetActive(false);
        Player1Win2.SetActive(false);
    }
    public int countProperty // ここでプロパティを使う。publicをつけます。
    {
        get { return lifeCount; }  // これがgettr。他のスクリプトから呼び出した時、returnのあとに書いた変数を返す。
        set { lifeCount = value; } // これがsettr。valueには他のスクリプトで代入された値が格納されます。（そこまで気にしなくて大丈夫。）
    }
    // Update is called once per frame
    void Update()
    {
        
        GetComponent<Text>().text = ("×") + lifeCount.ToString("0");
        if(lifeCount<=0)
        {
            active = true;
            Life.SetActive(true);
            fin.SetActive(true);
            Time.timeScale = 0.8f;
        }
        if (timer >= 100)
        {
            Life.SetActive(false);
            fin.SetActive(false);
            Player1Win.SetActive(true);
            Player1Win2.SetActive(true);
        }
        if(timer>=200)
        {
            SceneManager.LoadScene("titleScene" +
               "");
        }

    }
    private void FixedUpdate()
    {
        if (lifeCount <= 0)
        {
            timer++;
        }
    }
}
