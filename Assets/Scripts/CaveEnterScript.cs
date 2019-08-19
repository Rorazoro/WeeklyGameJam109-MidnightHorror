using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveEnterScript : MonoBehaviour
{

    public string caveLevelName;

    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.layer == 10)
        {
            SceneManager.LoadScene(caveLevelName);
        }
    }

}
