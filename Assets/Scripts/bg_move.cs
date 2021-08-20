using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg_move : MonoBehaviour
{
    private bool hasInitiate = false;
    private float speed = -0.1f;
    public RectTransform sprite;
    public float size;

    void Start()
    {
        size = sprite.sizeDelta.x * 4;
    }

    void Update()
    {
        transform.position += new Vector3(speed, 0, 0);

        if (transform.position.x <= -size+3.57f)
        {
            Destroy(this.gameObject);
        } else if (transform.position.x <= 1)
        {
            if (hasInitiate == false)
            {
                hasInitiate = true;
                GameObject obj = Instantiate(this.gameObject, new Vector3((transform.position.x+size), transform.position.y, transform.position.z), Quaternion.Euler(0,0,0));
            }
        }
    }
}
