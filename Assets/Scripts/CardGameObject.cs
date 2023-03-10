using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardGameObject : MonoBehaviour
{
    [SerializeField] Card card;
    [SerializeField] TMP_Text manaCostText, attackText, healthText, nameText, descriptionText;

    public Card GetCard()
    {
        return card;
    }

    void Start()
    {
        GetComponentInChildren<MeshRenderer>().material.SetTexture("_ArtTexture", card.GetTexture());

        manaCostText.text = card.GetManaCost().ToString();
        attackText.text = card.GetAttackPower().ToString();
        healthText.text = card.GetHealthPower().ToString();
        nameText.text = card.GetName();
        descriptionText.text = card.GetDescription();
    }
}
