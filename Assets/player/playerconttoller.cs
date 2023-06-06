using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerconttoller : MonoBehaviour
{
    Vector3 dir = Vector3.zero;   //ˆÚ“®•ûŒü‚Ì•Û‘¶
    float speed = 5.0f;
    void Start()
    {
        
    }


    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        transform.position += dir.normalized * speed * Time.deltaTime;

        //‰æ–Ê“àˆÚ“®§ŒÀ
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;
    }
}
