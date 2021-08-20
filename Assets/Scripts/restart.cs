using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {
	public void Update(){
        if(Input.GetKey("f"))
        {
            SceneManager.LoadScene ("MainScene");
        }
	}
}