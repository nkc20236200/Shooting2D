//----------------------------------------------------------------------------------------
// �ȖځF�Q�[���v���O���~���O
// ���e�F�Q�[���V�[���Ǘ�
// �S���FKen.D.Ohishi 2023.06.06
//----------------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public Text kyoriLabel; // �����\���e�L�X�g�I�u�W�F�N�g�ۑ�
    public Text shotLabel;  // �e�̋����\���e�L�X�g�I�u�W�F�N�g�ۑ�
    public Image timeGauge; // �c�莞�ԃQ�[�W�摜�I�u�W�F�N�g�ۑ�

    public GameObject itemPre; // �A�C�e���v���n�u�ۑ�

    // �v���[���[�R���g���[���[�R���|�[�l���g�ۑ�
    PlayerController playerCon; 

    // �c�莞�Ԃ𑼂̃X�N���v�g����ύX���邽�߂̐錾 public static
    public static float lastTime;

    // �����v�Z�p
    public static int kyori;              

    // �����̒l�𑼂̃X�N���v�g����ύX���邽�߂̃v���p�e�B
    // (public static���g��Ȃ����@)
    public int Kyori
    {
        set
        {
            kyori = value;
            kyori = Mathf.Clamp(kyori, 0, 999999);
        }
        get { return kyori; }
    }

    void Start()
    {
        kyori = 0;
        lastTime = 60;
        playerCon = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        // ������60 km/s �̑����ő��₷
        kyori++;
        kyoriLabel.text = kyori.ToString("D6") + "km";

        // ������600km�Ŋ���؂��Ƃ��ɃA�C�e���o��
        if(kyori % 600 == 0)
        {
            Instantiate(itemPre);
        }

        // �v���[���[�̒e���x�����擾���ĕ\��
        shotLabel.text = "ShotLevel " + playerCon.ShotLevel.ToString("D2");

        // �������ԂƃQ�[�W�����炷����
        lastTime -= Time.deltaTime;
        timeGauge.fillAmount = lastTime / 60f;

        // �������Ԃ��O��菬�����Ȃ�����^�C�g���V�[����
        if(lastTime < 0)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}

