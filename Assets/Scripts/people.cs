using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people : MonoBehaviour
{
    float aux = 1;
    float speed = -0.1f;
    void Start()
    {
       
    }

    void Update()
    {

        if(Time.timeSinceLevelLoad > aux)
        {
            aux++;
            speed -= 0.008f;
        }

        transform.position += new Vector3(speed, Random.Range(-0.05f, -0.03f), 0);
        if(transform.position.x <= -13f)
        {
            Destroy(this.gameObject);
        }
    }
}
