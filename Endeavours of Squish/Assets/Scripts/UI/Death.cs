﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadGame()
    {
        Debug.Log("Loading game...");
        SceneManager.LoadScene("Main");
    }
    public void LaodMenu()
    {
        Debug.Log("Loading menu...");
        SceneManager.LoadScene("main menu");
    }
}
