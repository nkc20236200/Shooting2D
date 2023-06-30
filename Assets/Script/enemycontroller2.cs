using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontroller2 : MonoBehaviour
{
    Transform player;

    void Start()
    {
        player = GameObject.Find("player").transform;
        
    }


    void Update()
    {
        float speed = 5f;
        Vector3 dir =Vector3.left;

        //if (transform.position.x < -9)  {
        //Vector3 pos =transform.position;
        //    pos.x = 9f;
        //    transform.position = pos;
        //}

        //dir.x = Mathf.Cos(Time.time * 5f);
        //dir.y = Mathf.Sin(Time.time * 5f);
        //Debug.Log(Time.time);

        dir = player.position - transform.position;

        transform.position += dir.normalized * speed * Time.deltaTime;


    }
}
