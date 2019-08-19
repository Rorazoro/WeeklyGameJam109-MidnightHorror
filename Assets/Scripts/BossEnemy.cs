using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossEnemy : MonoBehaviour {

    public int health;

    public string sceneToLoad = "Cutscene2";

    private void Update()
    {
        if (health <= 0) {
            SceneManager.LoadScene(sceneToLoad);

            Destroy(gameObject);
        }
        
    }

    public void TakeDamage(int damage) {
        health -= damage;

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == 9)
        {
            health -= 1;
        }

        Debug.Log("Enemy collided");
    }
}
