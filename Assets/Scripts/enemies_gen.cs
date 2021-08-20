using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemies_gen : MonoBehaviour
{
    public GameObject[] Enemy; //criar vetor
    private float timer = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= Random.Range(2,4))
        {
            var objeto = Enemy[Random.Range(0, Enemy.Length)];
            timer = 0;

            if(objeto.tag == "people")
            {
                Instantiate(objeto, new Vector3(3f, -0.5f, transform.position.z), Quaternion.Euler(0,0,0));
            } else if(objeto.tag == "enemy")
            {
                Instantiate(objeto, new Vector3(8f, Random.Range(-2.96f, -1.080001f), transform.position.z), Quaternion.Euler(0,0,0));
            }
        }
    }
}
