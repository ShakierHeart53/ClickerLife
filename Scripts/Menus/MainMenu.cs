using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator transitionAnim;

    public void PlayGame(int index)
    {
        StartCoroutine(ChangeScene(index));
    }

    public IEnumerator ChangeScene(int index)
    {
        transitionAnim.SetBool("FadeOut", true);
        transitionAnim.SetBool("FadeIn", false);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(index);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}