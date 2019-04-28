using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Shop Item!", menuName = "ScriptableObjects/ShopItem")]
public class ShopSO : ScriptableObject
{
    public Sprite icon;
    public string objectName;
    public float price;
    public float amountToAddPerSec;
}