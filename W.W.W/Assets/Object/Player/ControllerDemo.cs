using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerDemo : MonoBehaviour
{
   void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            Debug.Log("button0"); // A
        }
        if (Input.GetKeyDown("joystick button 1"))
        {
            Debug.Log("button1"); // B
        }
        if (Input.GetKeyDown("joystick button 2"))
        {
            Debug.Log("button2"); // X
        }
        if (Input.GetKeyDown("joystick button 3"))
        {
            Debug.Log("button3"); // Y
        }
        if (Input.GetKeyDown("joystick button 4"))
        {
            Debug.Log("button4"); // L
        }
        if (Input.GetKeyDown("joystick button 5"))
        {
            Debug.Log("button5"); // R
        }
        if (Input.GetKeyDown("joystick button 6"))
        {
            Debug.Log("button6"); // View (四角形二つのやつ)
        }
        if (Input.GetKeyDown("joystick button 7"))
        {
            Debug.Log("button7"); // Menu(≡)
        }
        if (Input.GetKeyDown("joystick button 8"))
        {
            Debug.Log("button8"); // Lスティック
        }
        if (Input.GetKeyDown("joystick button 9"))
        {
            Debug.Log("button9"); // Rスティック
        }
        float hori = Input.GetAxis("Horizontal");  // Lスティック横軸　（左-1～右1）
        float vert = Input.GetAxis("Vertical");    // Lスティック縦軸　（下-1～上1）
        if ((hori != 0) || (vert != 0))
        {
            Debug.Log("stick:" + hori + "," + vert);
        }
    }
}
