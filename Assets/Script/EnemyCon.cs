using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCon: MonoBehaviour
{
    Vector3 r = Vector3.zero; //ˆÚ“®•ûŒü
        float sp = 5;            //ˆÚ“®‘¬“x
       

        void Update()
        {
        if (transform.position.x < -9.0f){
            Destroy(gameObject);
        }

            //ˆÚ“®•ûŒü‚ðŒˆ’è
            r = Vector3.left;

            //Œ»Ý’n‚ÉˆÚ“®—Ê‚ð‰ÁŽZ
            transform.position += r.normalized * sp * Time.deltaTime;
        }
    private void OnTriggerEnter2D(Collider2D collision){
        gamedire.lasttime -= 10f;
        Destroy(gameObject);
        
    }
    

}
