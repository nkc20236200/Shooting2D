//----------------------------------------------------------------------------------------
// �ȖځF�Q�[���v���O���~���O
// ���e�F�v���[���[�̐���X�N���v�g
// �S���FKen.D.Ohishi 2023.06.06
//----------------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 dir;    // �ړ������ۑ�
    float speed;    // �ړ����x�ۑ�
    float timer;    // ���e�̔��ˊԊu�v�Z�p
    Animator anm;   // �A�j���[�^�[�R���|�[�l���g��ۑ�

    public GameObject shotPre; // �e�̃v���n�u���Z�b�g

    // ���L�����̃X�s�[�h�̒l�𑼂̃X�N���v�g����
    // �Q�ƁE�ύX���邽�߂̃v���p�e�B
    public float Speed
    {
        set
        {
            speed = value;
            speed = Mathf.Clamp(speed, 1, 20);
        }
        get { return speed; }
    }

    int shotLevel;  // ����̃��x��
    public int ShotLevel
    {
        set 
        { 
            shotLevel = value;
            shotLevel = Mathf.Clamp(shotLevel, 0, 12);
        }
        get { return shotLevel; }
    }

    void Start()
    {
        // �A�j���[�^�[�R���|�[�l���g�擾
        anm = GetComponent<Animator>(); 
        shotLevel = 0;  // �e���x��
        timer     = 0;  // ���ԏ�����
        speed     = 10; // �����X�s�[�h
    }

    void Update()
    {
        // �㉺���E�ړ�
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
        transform.position += dir.normalized * speed * Time.deltaTime;

        // C�L�[��shotLevel�ύX(�f�o�b�O�p)
        if (Input.GetKeyDown(KeyCode.C))
        {
            shotLevel = (shotLevel + 1) % 13;
        }

        // Z�L�[��������Ă���Ƃ��e�𔭎�
        timer += Time.deltaTime;
        if (timer >= 0.3f && Input.GetKey(KeyCode.Z))
        {
            timer = 0;
            shotLevel = (shotLevel < 0) ? 0 : shotLevel;
            for (int i = -shotLevel; i < shotLevel + 1; i++)
            {
                // �e�̐����ʒu�̓v���[���[�Ɠ����ꏊ
                Vector3 p = transform.position;

                // �v���[���[�̉�]�p�x���擾���A15�x�����炵�������ɒe����]������
                //Vector3 r = transform.rotation.eulerAngles + new Vector3(0, 0, 15f * i);
                //Quaternion rot = Quaternion.Euler(r);
                Quaternion rot = Quaternion.identity;
                rot.eulerAngles = transform.rotation.eulerAngles + new Vector3(0, 0, 15f * i);

                // �ʒu�Ɖ�]�����Z�b�g���Đ���
                Instantiate(shotPre, p, rot);
            }
        }

        // ��ʓ�����
        Vector2 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;

        // �A�j���[�V�����ݒ�
        if (dir.y == 0)         anm.Play("neutral");
        else if (dir.y == 1)    anm.Play("LMove");
        else if (dir.y == -1)   anm.Play("RMove");       
    }
}
