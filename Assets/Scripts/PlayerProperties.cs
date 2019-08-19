using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerProperties : MonoBehaviour
{

    public int startingHealth;
    public int healthLeft;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public string gameOverLevelName = "GameOver1";

    void Start ()
    {
        healthLeft = startingHealth;
    }

    void Update ()
    {
        if (healthLeft == 3)
        {
            heart3.SetActive(true);
            heart2.SetActive(true);
            heart1.SetActive(true);
        }
        if (healthLeft == 2)
        {
            heart3.SetActive(false);
            heart2.SetActive(true);
            heart1.SetActive(true);
        }
        if (healthLeft == 1)
        {
            heart3.SetActive(false);
            heart2.SetActive(false);
            heart1.SetActive(true);
        }
        if (healthLeft == 0)
        {
            heart3.SetActive(false);
            heart2.SetActive(false);
            heart1.SetActive(false);
        }

        if (healthLeft <= 0)
        {
            healthLeft = 0;

            SceneManager.LoadScene(gameOverLevelName);
        }
    }

    public void TakeDamage(int damage)
    {
        healthLeft -= damage;
    }

    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.layer == 11)
        {
            TakeDamage(1);
        }
        if (other.gameObject.layer == 15)
        {
            TakeDamage(1);
        }
    }

}
