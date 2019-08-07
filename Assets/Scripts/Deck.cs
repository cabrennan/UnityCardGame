using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class Deck : MonoBehaviour
{
    public GameObject obj;
    public Vector3 point = new Vector3(7.05f, 1.29f, 1.1f);
    public Quaternion rotation = Quaternion.Euler(50f, 0f, 0f);

    void Awake()
    {
        var deck = GetDeck();
        Debug.Log("after GetDeck");
        var positions = GetPositions();
        Debug.Log("after GetPostions");
        Deal(deck, positions);
    }

    public Queue GetPositions()
    {
        Queue pos = new Queue();
            
        pos.Enqueue((-2.93f, 2.43f, 1.28f));
        pos.Enqueue((-1.17f, 2.45f, 1.3f));
        pos.Enqueue((1.62f, 2.5f, 1.35f));
        pos.Enqueue((3.42f, 02.54f, 1.39f));
        return pos;
    }

    public List<Card> GetDeck()
    {
        List<Card> deck = new List<Card>();
        string[] itemGuids = AssetDatabase.FindAssets("t:Card");
        foreach (string s in itemGuids)
        {
            string path = AssetDatabase.GUIDToAssetPath(s);
            Card c = AssetDatabase.LoadAssetAtPath<Card>(path);
            deck.Add(c);
        }
        return deck;

    }

    public void Deal(List<Card> deck, Queue pos)
    {
        float[,] positions = new float[,]
        {
            { -2.93f, 2.43f, 1.28f, 45f, 0f, 0f },
            {-1.17f, 2.45f, 1.3f, 45f, 0f, 0f },
            { 1.62f, 2.5f, 1.35f,  45f, 0f, 0f},
            { 3.42f, 02.54f, 1.39f, 45f, 0f, 0f }
        };

        var idx = 0;

        foreach (Card c in deck)
        {
            
            obj = GameObject.Find(c.name);
            //obj = GameObject.FindWithTag(c.name);
            point = new Vector3(positions[idx,0], positions[idx,1], positions[idx,2]);
            rotation = Quaternion.Euler(positions[idx, 3], positions[idx, 4], positions[idx, 5]);

            if (c.enabled == true)
            {
                obj.GetComponent<SpriteRenderer>().sprite = c.face;
                
            }

            Instantiate(obj, point, rotation);
            Debug.Log("Placed " + c.name + "At point: " + point + "Enabled is: " + c.enabled);
            idx++;
        }


    }
}


