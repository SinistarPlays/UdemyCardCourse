using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{
    public TMP_Text manaCostText, attackText, healthText;

    public string cardName;
    public int manaCost;
    public int attackPower;
    public int healthPower;

    void Start()
    {
        manaCostText.text = manaCost.ToString();
        attackText.text = attackPower.ToString();
        healthText.text = healthPower.ToString();
    }
}
