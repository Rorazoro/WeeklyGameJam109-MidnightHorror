using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationQuitFunction : MonoBehaviour
{

    public void QuitApplication ()
    {
        Application.Quit();
        Debug.Log("Quit Application");
    }

}
