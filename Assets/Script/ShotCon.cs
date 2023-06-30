using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCon : MonoBehaviour
{
    Vector3 dir = Vector3.zero;
    float speed = 10f;
    Vector3 playerpos;
    int frameCount = 0;             
    const int deleteFrame = 180;
    void Start()
    {
        playerpos = transform.Find("player").localPosition;
    }



    void Update()
    {
           
        dir = Vector3.right;
        transform.position =playerpos += dir* speed * Time.deltaTime;

        if (++frameCount > deleteFrame)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        // d‚È‚Á‚½‘Šè‚Ìƒ^ƒO‚ªyEnemyz‚¾‚Á‚½‚ç
        if (c.tag == "Enemy")
        {
            // ©’eíœ
            Destroy(gameObject);
        }
    }
}
