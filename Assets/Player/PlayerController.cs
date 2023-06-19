using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 dir = Vector3.zero; //à⁄ìÆï˚å¸Çï€ë∂Ç∑ÇÈïœêî

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        float speed = 5;

        dir.x = Input.GetAxis("Horizontal");
        dir.y = Input.GetAxis("Vertical");

        transform.position += dir.normalized * speed * Time.deltaTime;

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x,-9f,9f);
        pos.y = Mathf.Clamp(pos.y,-5f,5f);
        transform.position = pos;

        if (dir.y == 0)
        {
            anim.Play("Player");
        }
        else if (dir.y == 1)
        {
            anim.Play("Player L");
        }
        else if (dir.y == -1)
        {
            anim.Play("Player R");
        }
       
           

        
    }
}
