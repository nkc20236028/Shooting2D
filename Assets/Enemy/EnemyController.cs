using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    Vector3 bir = Vector3.zero;  //�ړ�����
    float speed = 5;�@//�ړ����x
    GameObject Player;

    void Start()
    {
        this.Player = GameObject.Find("Player");
        //4�b�ŏ�����
        Destroy(gameObject, 4f);
    }

   
    void Update()
    {
        bir = Vector3.left;

        transform.position += bir.normalized * speed * Time.deltaTime;

        Vector2 p1 = transform.position;�@�@�@�@�@�@�@�@�@�@�@�@�@�@//��̒��S���W
        Vector2 p2 = this.Player.transform.position;�@�@�@�@�@�@�@�@//�v���C���̒��S���W
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;  //��̔��a
        float r2 = 0.5f;�@//�v���C���̔��a

        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseTime();

            //�@�Փ˂�����͏���
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //GameDirector.lasttime -= 10f;

        Destroy(gameObject);
    }

}
