using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float speed = 3f;
    GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameManager.Inst.GetTarget();
    }

    // Update is called once per frame
    void Update()
    {
        var delta = Time.deltaTime;
        var dir =  (target.transform.position - transform.position).normalized;
        transform.position = transform.position + (dir * speed * delta);
    }
}
