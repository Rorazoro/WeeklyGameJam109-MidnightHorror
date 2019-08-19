using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int health;
    public GameObject deathEffect;

    private Animator anim;

    // The child object's sprite renderer that shows enemy health.
    private SpriteRenderer eHealthRend;

    private void Start()
    {
        anim = GetComponent<Animator>();
        eHealthRend = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (health <= 0) {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    // The enemy health is inactive until they're hit, so this both sets it active and changes it.
    public void TakeDamage(int damage) {
        health -= damage;
        anim.SetBool("isHurt", true);
        eHealthRend.enabled = true;
        eHealthRend.sprite = Resources.Load<Sprite>("EHealth" + health);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == 9)
        {
            TakeDamage(1);
        }

        Debug.Log("Enemy collided");
    }
}
