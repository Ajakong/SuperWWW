using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropWepon : MonoBehaviour
{
    [SerializeField] GameObject SS;
    [SerializeField] GameObject MM;
    [SerializeField] GameObject KK;
    [SerializeField] GameObject BB;

    public int WeponNum;

    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (WeponNum)
        {
            case 0:
                {
                    Instantiate(SS);
                    break;
                }
            case 1:
                {
                    Instantiate(MM);
                    break;
                }
            case 2:
                {
                    Instantiate(KK);
                    break;
                }
            case 3:
                {
                    Instantiate(BB);
                    break;
                }
        }

        Destroy(this.gameObject);
    }
}
