using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;
    public Image cardFace;

    
    void Start()
    {
        cardFace.sprite = card.face;
       


    }


}
