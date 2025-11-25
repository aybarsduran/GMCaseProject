using UnityEngine;

public class PlayerInteractionController : MonoBehaviour
{
    private NPCDialogue _currentNPC;

    public void SetInteractableNPC(NPCDialogue npc)
    {
        _currentNPC = npc;
        UIManagerGame.Instance.ShowInteractionButton(true);
    }

    public void ClearInteractableNPC(NPCDialogue npc)
    {
        if (_currentNPC == npc)
        {
            _currentNPC = null;
            UIManagerGame.Instance.ShowInteractionButton(false);
            DialoguePanel.Instance.Close();

        }
    }

    public void Interact()
    {
        if (_currentNPC != null)
        {
            DialoguePanel.Instance.ShowDialogue(_currentNPC.sentences);
        }
    }
}
