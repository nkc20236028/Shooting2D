using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class shoot : MonoBehaviour
{
    Vector3 dir = Vector3.zero;  //移動方向
    float speed = 5;       //移動速度


    void Start()
    {
        
    }


    void Update()
    {
        dir = Vector3.right;


       
       transform.position += dir.normalized * speed * Time.deltaTime;
         

      


    }

    
}
