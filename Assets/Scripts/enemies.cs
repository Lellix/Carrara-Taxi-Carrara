using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemies : MonoBehaviour
{
    float aux = 1;
    float speed = -0.09f;
    private AudioSource audio;
    void Start()
    {
       
    }

    void Update()
    {
        if(Time.timeSinceLevelLoad > aux)
        {
            aux++;
            speed -= 0.005f;
        }

        transform.position += new Vector3(speed, 0, 0);
        if(transform.position.x <= -13f)
        {
            Destroy(this.gameObject);
        }
    }


}
