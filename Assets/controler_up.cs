using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler_up : MonoBehaviour
{
    public float speed = 0.1f;
    
        
    public void Jumperdown()
    {
        transform.Translate(Vector3.down * speed);  
    }

}