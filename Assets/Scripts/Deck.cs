using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Deck : MonoBehaviour
{
    #region Singleton

    // items list will need Sprite association for game image
    // In heiarchy attach approriate collider to sprite
    // Attach interactibile script to item in heiarchy
    // Attach itempickup script to item in heiarchy
    // In inspector insert Inventory/items/item to variable in ItemPickup(script) dialog box. 

    public static Deck instance;
    public List<Card> deck; 
    //public Queue<Card> cardQueue;

    public Vector3[] positions = new Vector3[4];

   // positions[0] = new Vector3(-2.93f,2.43f, 1.28f);
   // positions[1] = new Vector3(1.62f, 2.5f, 1.35f);
   // positions[2] = new Vector3(0.03f, -0.82f, -1.95f);
   // positons[3] = new Vector3(-1.17f, 2.45f, 1.3f);
    
    void Awake()
    {
        instance = this;
        //cardQueue = new Queue<Card>();
        deck =  new List<Card>();
        ShuffleDeck();
        Debug.Log("after ShuffleDeck");
        Deal();
    }

    #endregion

    //public delegate void OnItemChanged();
    //public OnItemChanged onItemChangedCallback;

    // public int space = 15; // number of inventory slots 
    // public Vector3 position;

    //private void Start()
    //{
    //}




    public void Add(Card c)
    {
        deck.Add(c);
   //     if (onItemChangedCallback != null)
   //     {
   //         onItemChangedCallback.Invoke();
   //     }
   
   }

    public void Remove(Card c)
    {
        deck.Remove(c);
    }


    public void ShuffleDeck()
    {
        Debug.Log("Inside ShuffleDeck");
        string[] cardGuids = AssetDatabase.FindAssets("t:Card");
        foreach (string s in cardGuids)
        {
            string path = AssetDatabase.GUIDToAssetPath(s);
            Card c = AssetDatabase.LoadAssetAtPath<Card>(path);
                this.Add(c);
            deck.Add(c);
            Debug.Log("Added card: " + c.name);
        }
    }

    void Deal()
    {
        int i = 0;
        foreach (Card c in deck)
        {
            Debug.Log("Working on " + c.name);
            Instantiate(c, new Vector3(-2.93f, 2.43f, 1.23f), Quaternion.identity);
            
            // newcard.name = c.name;
            //c.  = positions[i];
            i++;
        }
    }

}
