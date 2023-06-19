using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class shoot : MonoBehaviour
{
    Vector3 dir = Vector3.zero;  //ˆÚ“®•ûŒü
    float speed = 5;       //ˆÚ“®‘¬“x


    void Start()
    {
        
    }


    void Update()
    {
        dir = Vector3.right;


       
       transform.position += dir.normalized * speed * Time.deltaTime;
         

      


    }

    
}
