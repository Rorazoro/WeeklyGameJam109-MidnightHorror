using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttacker : MonoBehaviour
{

    public float timeout = 10f;
    public float s_timeout;

    public Animator animator;

    public Transform wolfLead;
    public Vector3 originalWolfLead;

    public Rigidbody2D wolfLeadRB;

    public float wolfSpeed;

    void Start ()
    {
        s_timeout = timeout;

        originalWolfLead = wolfLead.position;

        wolfLeadRB.velocity = new Vector2(0, wolfLeadRB.velocity.y);

        animator.SetBool("attack", false);
    }

    void Update ()
    {
        if (s_timeout <= 0f)
        {
            animator.SetBool("attack", true);
            s_timeout = timeout;
        } else
        {
            s_timeout -= Time.deltaTime;
        }
    }

    public void Attack ()
    {
        wolfLeadRB.velocity = new Vector2(-wolfSpeed, wolfLeadRB.velocity.y);
    }

    public void Idle ()
    {
        animator.SetBool("attack", false);
        wolfLeadRB.velocity = new Vector2(0, wolfLeadRB.velocity.y);
        wolfLead.position = originalWolfLead;
    }
}
