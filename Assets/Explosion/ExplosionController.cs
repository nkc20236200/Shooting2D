using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    // �A�j���[�V�����̍Ō�ɌĂяo�����\�b�h
    // �����̃A�j���[�V�����N���b�v�ɃC�x���g�Ƃ��ēo�^
    public void ExepDelete()
    {
        // �����i�����j�폜
        Destroy(gameObject);
    }
}
