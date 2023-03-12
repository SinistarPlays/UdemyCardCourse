using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    [SerializeField] List<CardGameObject> cardsInHand = new List<CardGameObject>();

    void Start()
    {
        for (int i = 0; i < cardsInHand.Count; i++)
        {
            Debug.Log("Card: " + cardsInHand[i].GetCard().GetName());
        }
    }
}
