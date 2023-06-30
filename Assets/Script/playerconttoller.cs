using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerconttoller : MonoBehaviour
{
    Vector3 dir = Vector3.zero;   //�ړ������̕ۑ�
    float speed = 5.0f;
    Animator anim;
    public GameObject MyShotPre;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        transform.position += dir.normalized * speed * Time.deltaTime;

        //��ʓ��ړ�����
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;

        //�A�j���[�V�����ݒ�
        if (dir.y == 0)  {
            //�A�j���[�V�����N���b�v�uplayer�v���Đ�����
            anim.Play("player");
        }
        else if (dir.y == 1)  {
            anim.Play("playerl");
        }
        else if (dir.y == -1)  {
            anim.Play("playerr");
        }

        if (Input.GetKeyDown(KeyCode.Z))  {
            GameObject MayShot = Instantiate(MyShotPre);
        }
    }
}
