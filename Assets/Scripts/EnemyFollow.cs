using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {


    public float speed;

    public Transform target;

    private Vector3 scale;

    public bool lookForPlayerAsTarget = false;

    
    void Start() 
    {
        scale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);

        if (lookForPlayerAsTarget && target == null)
        {
            GameObject player = GameObject.FindWithTag("Player");
            target = player.transform;
        }
    }

    void FixedUpdate() 
    {


        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    void Update ()
    {
        if (target.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(scale.x, scale.y, scale.z);
        } else
        {
            transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
        }
    }
}
