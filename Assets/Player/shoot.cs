using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class shoot : MonoBehaviour
{
    Vector3 dir = Vector3.zero;  //�ړ�����
    float speed = 5;       //�ړ����x


    void Start()
    {
        
    }


    void Update()
    {
        dir = Vector3.right;


       
       transform.position += dir.normalized * speed * Time.deltaTime;
         

      


    }

    
}
