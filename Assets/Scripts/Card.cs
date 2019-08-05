using UnityEngine;
using System.Collections;


[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{

    new public string name = "New Card";    // Name of the item
    public Sprite icon = null;              // Item icon
    public string suit;
    public int rank;

    
    public bool enabled = true; // If true can be clicked on
    public Vector3 pos;

    public GameObject obj;
    public Collider2D objCollider;
    private Camera cam;
    private Plane[] planes;


    public Vector3 center;
    // Called when the item is pressed in the inventory
    public virtual void Use()
    {
        // Use the item

    }



    // Call this method to remove the item from inventory
 //   public void RemoveFromDeck()
 //   {
 //       Deck.instance.Remove(this);
 //   }

    public void SetPosition()
    {
        Debug.Log("Positioning: " + this.name);

        // Set item position;
        bool visible = false;
        do
        {
            
            float screenX = Random.Range(-5.0f, 1.0f);
            
            float screenY = Random.Range(-4.0f, 3.0f);
            float screenZ = Random.Range(-4.0f, 0.0f);
            Vector3 point = new Vector3(screenX, screenY, screenZ);

            Debug.Log("Testing position: " + pos.ToString());
            obj = GameObject.Find("/HiddenObjects/" + this.name);
            Instantiate(obj, point, Quaternion.identity);

            cam = Camera.main;
            planes = GeometryUtility.CalculateFrustumPlanes(Camera.main);
            Debug.Log("after planes");
            objCollider = obj.GetComponent<Collider2D>();
            Debug.Log("after collider");
            if (GeometryUtility.TestPlanesAABB(planes, objCollider.bounds))
            {
                visible = true;
            }
            else
            {
                Debug.Log("Didn't find a visible position for " + this.name);
            }

            visible = true;

        } while (!visible);
    }

    public void NewSetPosition()
    {
        Debug.Log("Positioning: " + this.name);
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), Camera.main.farClipPlane / 2));
        obj = GameObject.Find("/HiddenObjParent/" + this.name);
        obj.transform.position = screenPosition;

    }

    public void SPos()
    {
        Debug.Log("Positioning: " + this.name);
        
    }

}
