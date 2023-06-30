using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class enemygene : MonoBehaviour
{
    public GameObject enemyPre;
    float delta;
    float span;

    void Start()
    {
        delta = 0;
        span = 1f;
    }

    void Update()
    {
        delta += Time.deltaTime;
        if (delta>span)  {
            GameObject go =Instantiate(enemyPre);
            float py = Random.Range(-6f, 7f);
            go.transform.position = new Vector3(10, py, 0);

            delta = 0;
            span -= (span > 0.5f) ? 0.01f : 0f;
        
        }
        
    }
}
