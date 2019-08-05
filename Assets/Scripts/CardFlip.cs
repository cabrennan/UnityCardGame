using System.Collections.Generic;
using UnityEngine;

public class CardFlip : Interactable
{

    public Card card;
    public delegate void OnItemChanged();
    public OnItemChanged onitemChangedCallback;

    // When the player interacts with the item
    public override void Interact()
    {
        base.Interact();
        OnMouseDown();
    }

    // Pick up the item
    void OnMouseDown()
    {
        if (card.enabled)
        {
            Debug.Log("Flipping " + card.name);
            Destroy(gameObject);    // Destroy item from scene
            card.enabled = false;
            Deck.instance.Remove(card);
        }
    }
}


   