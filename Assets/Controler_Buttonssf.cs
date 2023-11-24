using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler_Buttonssf : MonoBehaviour
{
    public float speed = 0.1f;
    
        
    public void Jumperdown()
    {
        transform.Translate(Vector3.down * speed);  
    }
 public void Jumperup()
    {
        transform.Translate(Vector3.up * speed);  
    }
     public void Jumperleft()
    {
        transform.Translate(Vector3.left * speed);  
    } 
     public void Jumperright()
     {
        transform.Translate(Vector3.right * speed);  
    }
}