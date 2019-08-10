using UnityEngine;

public class CardUI : Interactable
{
    public Card card;

    public override void Interact()
    {
        base.Interact();
        Remove();
    }

    void Remove()
    {
        Debug.Log("Picking up :" + card.name);
        Deck.instance.Remove(card);

    }




}
