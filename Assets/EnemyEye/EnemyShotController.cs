using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotController : MonoBehaviour
{
    Vector3 dir;        // �ړ�����
    float speed;        // �ړ����x
    GameDirector gd;    // GameDirector�R���|�[�l���g�ۑ�
    Transform player;   // �v���[���[�̃g�����X�t�H�[���R���|�[�l���g��ۑ�

    void Start()
    {
        // �v���[���[�̏���ۑ�
        player = GameObject.Find("Player").transform;
        
        // �e�̑��x
        speed = 12f;

        // �e�̔��˕����i�G�̌��ݒn���猩���v���[���[�̕����j
        dir = player.position - transform.position;

        // GameDirector�R���|�[�l���g���擾
        gd = GameObject.Find("GameDirector").GetComponent<GameDirector>();

        // ����
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        // �ړ�����
        transform.position += dir.normalized * speed * Time.deltaTime;        
    }

    // �d�Ȃ蔻��  
    void OnTriggerEnter2D(Collider2D c)
    {
        // �d�Ȃ�������̃^�O���yPlayer�z��������
        if (c.tag == "Player")
        {
            gd.Kyori -= 500;        // ���������炷
            Destroy(gameObject);    // �����i�G�e�j�폜
        }
    }

}
