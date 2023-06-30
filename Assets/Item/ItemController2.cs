using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController2 : MonoBehaviour
{
    SpriteRenderer spRender;    // �����_���[�R���|�[�l���g�擾
    Vector3 pos;                // �o���ʒu
    int itemType;               // �A�C�e���̎��
    float speed;                // �������x

    void Start()
    {
        itemType = Random.Range(0, 3);  // �A�C�e���̎��0�`2
        speed = 5f;                     // �������x

        // itemType=0:�� / itemType=1:�� / itemType=2:�@
        Color[] col = { Color.red, Color.green, Color.blue };
        spRender = GetComponent<SpriteRenderer>();
        spRender.color = col[itemType];

        // �o���ʒu
        pos.x = Random.Range(-8f, 8f);
        pos.y = 6f;
        pos.z = 0;
        transform.position = pos;

        // ����3�b
        Destroy(gameObject, 3f); 
    }

    void Update()
    {
        // �������� speed m/s �ňړ�
        transform.position += Vector3.down * speed * Time.deltaTime;
    }

    // �d�Ȃ蔻��
    void OnTriggerEnter2D(Collider2D c)
    {
        // �d�Ȃ�������̃^�O���yPlayer�z��������
        if (c.gameObject.tag == "Player")
        {
            // PlayerController�R���|�[�l���g��ۑ�
            PlayerController pCon = c.gameObject.GetComponent<PlayerController>();

            // �A�C�e���̎�ޕʂɏ�����ύX
            if (itemType == 0)       // �ԁF�e���x���{�P
            {
                pCon.ShotLevel += 1; 
            }
            else if (itemType == 1)  // �΁F�X�s�[�h�{�T
            {
                pCon.Speed += 5;     
            }
            else if (itemType == 2)  // �F�e���x���O�@�X�s�[�h�T
            {
                pCon.Speed     = 5;
                pCon.ShotLevel = 0;
            }

            // �����i�A�C�e���j�폜
            Destroy(gameObject);
        }
    }
}
