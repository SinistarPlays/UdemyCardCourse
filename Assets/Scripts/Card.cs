using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "New Card ScriptableObject")]
public class Card : ScriptableObject
{
    [SerializeField] string cardName;
    [SerializeField] int manaCost;
    [SerializeField] int attackPower;
    [SerializeField] int healthPower;

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
}