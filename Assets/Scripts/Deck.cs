using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class Deck : MonoBehaviour
{
    public Vector3 thisPos = new Vector3(-2.93f, 2.43f, 1.28f);
    public GameObject obj;

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
            { -2.93f, 2.43f, 1.28f },
            {-1.17f, 2.45f, 1.3f },
            { 1.62f, 2.5f, 1.35f },
            { 3.42f, 02.54f, 1.39f }
        };

        var idx = 0;

        foreach (Card c in deck)
        {
            
            //(Vector3)pos.Dequeue();
            Debug.Log("position is: " + pos);
            Debug.Log("card is: " + c.name);


            

            // Vector3[] positionArray = new[] { new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f) };

            obj = GameObject.Find(c.name);
            var stuff  = pos.Dequeue();

            Debug.Log("Stuff: " + stuff.ToString());

            //thisPos = StringToVector3(stuff.ToString);

            Vector3 point = new Vector3(positions[idx,0], positions[idx,1], positions[idx,2]);


            Instantiate(obj, point, Quaternion.identity);
            idx++;
        }


    }
}


