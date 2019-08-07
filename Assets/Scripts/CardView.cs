using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardView : MonoBehaviour
{
    public Card card;

    public void Start()
    {
        card.enabled = false;
    }
    // Start is called before the first frame update
    //public Sprite face = Card.face;
    // public icon = Card.face;

}
