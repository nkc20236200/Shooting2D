using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCon: MonoBehaviour
{
    Vector3 r = Vector3.zero; //�ړ�����
        float sp = 5;            //�ړ����x
       

        void Update()
        {
        if (transform.position.x < -9.0f){
            Destroy(gameObject);
        }

            //�ړ�����������
            r = Vector3.left;

            //���ݒn�Ɉړ��ʂ����Z
            transform.position += r.normalized * sp * Time.deltaTime;
        }
    private void OnTriggerEnter2D(Collider2D collision){
        gamedire.lasttime -= 10f;
        Destroy(gameObject);
        
    }
    

}
