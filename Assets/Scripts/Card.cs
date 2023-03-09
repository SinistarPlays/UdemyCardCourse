using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "New Card ScriptableObject")]
public class Card : ScriptableObject
{
    [SerializeField] string cardName;
    [SerializeField] string cardDescription;
    [SerializeField] int manaCost;
    [SerializeField] int attackPower;
    [SerializeField] int healthPower;
    [SerializeField] Texture2D cardArtTexture;

    public string GetName()
    {
        return cardName;
    }

    public string GetDescription()
    {
        return cardDescription;
    }

    public int GetManaCost()
    {
        return manaCost;
    }

    public int GetAttackPower()
    {
        return attackPower;
    }

    public int GetHealthPower() 
    { 
        return healthPower; 
    }

    public Texture2D GetTexture()
    {
        return cardArtTexture;
    }

    public void SetName(string cardName)
    {
        this.cardName = cardName;
    }

    public void SetDescription(string cardDescription)
    {
        this.cardDescription = cardDescription;
    }

    public void SetManaCost(int manaCost)
    {
        this.manaCost = manaCost;
    }

    public void SetAttackPower(int attackPower)
    {
        this.attackPower = attackPower;
    }

    public void SetHealth(int healthPower)
    {
        this.healthPower = healthPower;
    }
}
