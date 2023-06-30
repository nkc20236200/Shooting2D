using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gamedire : MonoBehaviour
{
    public Text kyorilabel;
    int kyori;
    public static float lasttime;
    public Image timegauge;
    void Start()
    {
        kyori = 0;
        lasttime = 100f;
        
    }


    void Update()
    {
        kyori++;
        kyorilabel.text = kyori.ToString("D6")+("km");

        lasttime -= Time.deltaTime;
        timegauge.fillAmount = lasttime / 100f;
        if (lasttime < 0)  {
            SceneManager.LoadScene("gamescene");
        
        }
    }
}
