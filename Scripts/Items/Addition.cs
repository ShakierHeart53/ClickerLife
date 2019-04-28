using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Addition : MonoBehaviour
{
    public ShopSO scriptableObject;

    private Player player;

    private float startTimer = 7.5f;
    private float timer;

    private void Start()
    {
        timer = startTimer;

        player = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Player>();
    }

    private void Update()
    {
        if(timer <= 0)
        {
            player.health += scriptableObject.amountToAddPerSec;
            timer = startTimer;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}