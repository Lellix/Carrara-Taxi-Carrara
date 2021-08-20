using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cab : MonoBehaviour
{

    float seed = 10.0f;
    float distance = 0;
    private Text score;
    public Text warningPM;
    float aux = 1;
    int races = 0;
    public int PM = 0;
    public int PMTime = 0;

    void Start()
    {    
        distance = Random.Range(1f, 10f);
        distance = Mathf.Floor(distance*10)/10;
        score = GameObject.Find("Canvas").transform.Find("Text").GetComponent<Text>();
    }

    void Update()
    {
        if (Input.GetKey("up") & (transform.position.y <= 0))
        {
            transform.position += new Vector3(0, 0.05f, 0);
        } else if (Input.GetKey("down") & (transform.position.y >= -4))
        {
            transform.position += new Vector3(0, -0.05f, 0);
        }

        if(transform.position.y >= -0.780001f || transform.position.y <= -3.2f)
        {
            warningPM.enabled = true;
            PM++;
            PMTime++;
        } else {
            warningPM.enabled = false;
            PMTime = 0;
        }

        if(PM >= 240 || PMTime >= 120){
            SceneManager.LoadScene ("GameOverPM");
        }
        
        if(distance <= 0)
        {
            seed += 5;
            races ++;
            distance = Random.Range(1.0f, seed);
            distance = Mathf.Floor(distance*10)/10;
        } else if(Time.timeSinceLevelLoad > aux)
        {
            aux ++;
            distance -= 0.2f;
            distance = Mathf.Floor(distance*10)/10;
        }
        score.text = "Distancia restante: "+distance.ToString()+"    Corridas completadas: "+races.ToString();  
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "enemy")
        {
            StartCoroutine(WaitForRogicaGritando(col));
            
        } else if(col.gameObject.tag == "people")
        {
            StartCoroutine(WaitForRogicaGritando(col));
           /* distance = Random.Range(1.0f, 10.0f);
            distance = Mathf.Floor(distance*10)/10;
            col.gameObject.GetComponent<AudioSource>().Play();
            SceneManager.LoadScene ("GameOverMenu");*/
        }
    }

    IEnumerator WaitForRogicaGritando(Collision2D col)
    {
        distance = Random.Range(1.0f, 10.0f);
        distance = Mathf.Floor(distance*10)/10;
        col.gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene ("GameOverMenu");
    }

}
