using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeponPos : MonoBehaviour
{
    Vector3 Pos;
    public float posX;
    public string name;

    void Start()
    {
        Pos = new Vector3(posX, -2.2f, 0f);
        this.transform.position = Pos;
        
        gameObject.name = name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
