using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    Vector3 dir = Vector3.zero;
    float speed = 20f;
    public GameObject shotPre;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        transform.position += dir.normalized * speed * Time.deltaTime;


        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject MayShot = Instantiate(shotPre);
        }
    }
}
