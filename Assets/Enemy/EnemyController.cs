using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    Vector3 bir = Vector3.zero;  //移動方向
    float speed = 5;　//移動速度
    GameObject Player;

    void Start()
    {
        this.Player = GameObject.Find("Player");
        //4秒で消える
        Destroy(gameObject, 4f);
    }

   
    void Update()
    {
        bir = Vector3.left;

        transform.position += bir.normalized * speed * Time.deltaTime;

        Vector2 p1 = transform.position;　　　　　　　　　　　　　　//矢の中心座標
        Vector2 p2 = this.Player.transform.position;　　　　　　　　//プレイヤの中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;  //矢の半径
        float r2 = 0.5f;　//プレイヤの半径

        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseTime();

            //　衝突した矢は消す
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //GameDirector.lasttime -= 10f;

        Destroy(gameObject);
    }

}
