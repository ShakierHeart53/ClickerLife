using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoreMenu : MonoBehaviour
{
    public GameObject[] menus;
    public int index = 0;

    public Animator anim;

    public GameObject yes;
    public GameObject no;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (index < menus.Length)
            {
                menus[index].SetActive(true);
                index += 1;
            }

            if(index == menus.Length)
            {
                yes.SetActive(true);
                no.SetActive(true);
            }
        }
    }

    public void Yes()
    {
        StartCoroutine(SceneLoad(2, false, true));
    }

    public void No()
    {
        StartCoroutine(SceneLoad(0, false, true));
    }

    public IEnumerator SceneLoad(int index, bool fadeIn, bool fadeOut)
    {
        anim.SetBool("FadeIn", fadeIn);
        anim.SetBool("FadeOut", fadeOut);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(index);
    }
}