using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCard : MonoBehaviour
{
    [SerializeField] CardGameObject cardGameObject;
    [SerializeField] int cardCount;
    [SerializeField] Transform parentTransform = null;

    void Awake()
    {
        for (int i = 0; i < cardCount; i++)
        {
            CardGameObject card = Instantiate(cardGameObject);
            card.name = cardGameObject.GetCard().GetName();
            card.transform.parent = parentTransform;
        }

        Destroy(this.gameObject);
    }
}
