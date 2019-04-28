using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public Button[] buttons;
    public TextMeshProUGUI[] prices;
    public TextMeshProUGUI[] names;
    public ShopSO[] objects;

    private void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].image.sprite = objects[i].icon;
            prices[i].text = objects[i].price.ToString() + " Health";
            names[i].text = objects[i].objectName;
            buttons[i].name = objects[i].objectName;
        }
    }
}