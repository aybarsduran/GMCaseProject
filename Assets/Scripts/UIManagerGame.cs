using UnityEngine;

public class UIManagerGame : MonoBehaviour
{
    public static UIManagerGame Instance;

    [SerializeField] private GameObject _interactionButton;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        _interactionButton.SetActive(false);
    }
    public void ShowInteractionButton(bool show)
    {
        _interactionButton.SetActive(show);
    }
}
