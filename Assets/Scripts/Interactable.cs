using UnityEngine;
using UnityEngine.AI;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public Transform interactionTransform;

    // This method is meant to be overwritten
    public virtual void Interact()
    {

    }

}
