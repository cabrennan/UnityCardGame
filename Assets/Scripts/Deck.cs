using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    #region Singleton

    public static Deck instance;

    void Awake()
    {
        instance = this;
    }

    #endregion

    // Our current list of items in the inventory
    public List<Card> deck = new List<Card>();

    public void Add(Card card)
    {
        deck.Add(card);
    }
    public void Remove(Card card)
    {
        deck.Remove(card);
    }
}
