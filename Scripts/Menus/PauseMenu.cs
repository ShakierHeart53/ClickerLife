using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    public bool isOpen;

    private void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isOpen)
            {
                Close();
                isOpen = false;
            }

            if(!isOpen)
            {
                Open();
                isOpen = true;
            }
        }
    }

    public void Open()
    {
        pauseMenu.SetActive(true);
    }

    public void Close()
    {
        pauseMenu.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}