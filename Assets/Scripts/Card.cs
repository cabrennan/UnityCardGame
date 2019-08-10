using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    new public string name = "New Card";
    public int rank;
    //blic Suit suit;

    [System.Serializable]
    public enum Suit
    {
        Spade,
        Heart,
        Diamond,
        Club
    }

    public Suit suit;
    
    public virtual void Use()
    {

    }

    public void RemoveFromDeck()
    {
        Deck.instance.Remove(this);
    }

}
