using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{

    private bool isPaused;
    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseSwitch();
        }

        if (isPaused)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        } else
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void PauseSwitch ()
    {
        isPaused = !isPaused;
    }
}
