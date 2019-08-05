using UnityEngine;
using UnityEngine.AI;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public Transform interactionTransform;

    // This method is meant to be overwritten
    public virtual void Interact()
    {
        Debug.Log("interacting with: " + transform.name);

    }

    void OnDrawGizmosSelected()
    {
        if (interactionTransform == null)
        {
            interactionTransform = transform;
        }
        Gizmos.color = Color.green;
        // Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }

}
