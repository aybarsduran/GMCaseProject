using UnityEngine;

public class NPCInteractionTrigger : MonoBehaviour
{
    private NPCDialogue npcDialogue;

    private void Awake()
    {
        npcDialogue = GetComponentInParent<NPCDialogue>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered to area");
            PlayerInteractionController controller = other.GetComponent<PlayerInteractionController>();
            if (controller != null)
                controller.SetInteractableNPC(npcDialogue);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInteractionController controller = other.GetComponent<PlayerInteractionController>();
            if (controller != null)
                controller.ClearInteractableNPC(npcDialogue);
        }
    }
}
