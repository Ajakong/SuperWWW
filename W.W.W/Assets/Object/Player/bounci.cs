using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounci : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Physics Material2D‚ðŽæ“¾
        var material = GetComponent<Rigidbody2D>().sharedMaterial;

        material.friction = 0.5f;
        material.bounciness = 0;
    }

    
}
