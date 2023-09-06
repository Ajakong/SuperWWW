using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Des : MonoBehaviour
{
    public string name;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == name)
        {
            Destroy(this.gameObject);
        } 
    }

}
