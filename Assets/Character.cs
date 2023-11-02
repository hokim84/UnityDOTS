using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
           
    }



    // Update is called once per frame
    void Update()
    {
        var delta = Time.deltaTime;

        var moveH = Input.GetAxis("Horizontal");
        if(moveH != 0 )
        {
            transform.Translate(new Vector3(moveH * speed * delta, 0f, 0f));
        }

        var moveV = Input.GetAxis("Vertical");
        if (moveV != 0)
        {
            transform.Translate(new Vector3(0f, moveV * speed * delta, 0f));
        }
    }
}
