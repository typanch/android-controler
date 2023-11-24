using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler_jostik_button : MonoBehaviour
{
    public Joystick joystick;
    public float speed = 0.1f;

    void FixedUpdate()
    {
        float moveHorizontal = joystick.Horizontal;
        
        transform.Translate(Vector3.right * moveHorizontal * speed);
    }

    public void Jumper()
    {
        transform.Translate(Vector3.up * speed);  
    }

}