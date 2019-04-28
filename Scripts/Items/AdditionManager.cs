using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AdditionManager : MonoBehaviour
{
    public Player player;

    private GameObject[] spawned;

    public TextMeshProUGUI perMinuteText;
    public float perMinute = 0f;
    public int amount = 0;

    private void Update()
    {
        spawned = player.spawnedCharacters.ToArray();
        if (amount <= spawned.Length)
        {
            for (int i = 0; i < spawned.Length; i++)
            {
                Addition addition = spawned[i].GetComponent<Addition>();
                perMinute += addition.scriptableObject.amountToAddPerSec * 8;
                amount++;
            }
        }

        perMinuteText.text = "Health per Minute - " + perMinute.ToString();
    }
}