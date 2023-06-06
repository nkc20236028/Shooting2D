using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 dir = Vector3.zero; //ˆÚ“®•ûŒü‚ğ•Û‘¶‚·‚é•Ï”
   
    void Start()
    {
        
    }

    
    void Update()
    {
        float speed = 5;

        dir.x = Input.GetAxis("Horizontal");
        dir.y = Input.GetAxis("Vertical");

        transform.position += dir.normalized * speed * Time.deltaTime;

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, speed, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, speed, -9f, 5f);
        transform.position = pos;
    }
}
