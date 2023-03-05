using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardGameObject : MonoBehaviour
{
    [SerializeField] Card card;
    [SerializeField] TMP_Text manaCostText, attackText, healthText;

    void Start()
    {
        manaCostText.text = card.GetManaCost().ToString();
        attackText.text = card.GetAttackPower().ToString();
        healthText.text = card.GetHealthPower().ToString();
    }
}
