using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    float speed;

    void Start()
    {
        speed = 10f;             // �e���x
        Destroy(gameObject, 2f); // �����Q�b
    }

    void Update()
    {
        // �ړ�
        transform.position += transform.up * speed * Time.deltaTime;
    }

    // �d�Ȃ蔻��
    void OnTriggerEnter2D(Collider2D c)
    {
        // �d�Ȃ�������̃^�O���yEnemy�z��������
        if (c.tag == "Enemy")
        {
            // ���e�폜
            Destroy(gameObject);
        }
    }
}

