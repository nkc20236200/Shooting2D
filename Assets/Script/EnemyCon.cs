using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCon: MonoBehaviour
{
    Vector3 r = Vector3.zero; //移動方向
        float sp = 5;            //移動速度
       

        void Update()
        {
        if (transform.position.x < -9.0f){
            Destroy(gameObject);
        }

            //移動方向を決定
            r = Vector3.left;

            //現在地に移動量を加算
            transform.position += r.normalized * sp * Time.deltaTime;
        }
    private void OnTriggerEnter2D(Collider2D collision){
        gamedire.lasttime -= 10f;
        Destroy(gameObject);
        
    }
    

}
