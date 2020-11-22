using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageGame : MonoBehaviour
{
    public static ManageGame Instance;
    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }


    public void RestartGame()
    {
        Invoke("RestartAfterTime", 2f);
    }

    public void RestartAfterTime()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Survive Fall");
    }

}
