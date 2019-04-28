using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("Other")]
    public float health = 0;
    public Animator transitionAnim;
    public AudioManager audio;
    public ParticleSystem particles;

    [Header("Text")]
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI shopHealthText;
    public TextMeshProUGUI gameOverText;

    [Header("GameObjects")]
    public GameObject gameView;
    public GameObject shopView;
    public Transform[] spawnpoints;

    [Header("Buttons")]
    public Button pressButton;
    public Button deadPressButton;
    public Button openShop;

    [Header("Sprites")]
    public Sprite normalBG;
    public Sprite deadBG;
    public Sprite BG;

    [Header("Prefabs")]
    public GameObject[] characters;
    public List<GameObject> spawnedCharacters;

    private void Start()
    {
        pressButton.gameObject.SetActive(true);

        spawnedCharacters = new List<GameObject>();

        healthText.gameObject.SetActive(true);
        shopHealthText.gameObject.SetActive(false);
    }

    private IEnumerator Kill()
    {
        transitionAnim.SetBool("FadeOut", true);
        transitionAnim.SetBool("FadeIn", false);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(3);
    }

    public void AddHealth(float amount)
    {
        health += amount;
    }

    public void TakeHealth(float amount)
    {
        health -= amount;

        if(health >= 0)
        {
            audio.PlaySound("ItemBought");
        }
    }

    private void Update()
    {
        healthText.text = "HEALTH - " + health.ToString();

        shopHealthText.text = "HEALTH - " + health.ToString();

        if(health < 0)
        {
            StartCoroutine(Kill());
        }
    }

    public void OpenShop()
    {
        gameView.SetActive(false);
        shopView.SetActive(true);
        shopHealthText.gameObject.SetActive(true);
    }

    public void CloseShop()
    {
        gameView.SetActive(true);
        shopView.SetActive(false);
        shopHealthText.gameObject.SetActive(false);
    }

    public void InstantiateObject(int index)
    {
        Vector3 spawnPos = Random.insideUnitCircle.normalized;
        GameObject go = Instantiate(characters[index], spawnpoints[Random.Range(0, spawnpoints.Length)].position, Quaternion.identity, gameView.transform);
        spawnedCharacters.Add(go);
        go.SetActive(true);
    }
}