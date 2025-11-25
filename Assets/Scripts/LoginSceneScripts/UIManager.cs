using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private GameObject _loginPanel;
    [SerializeField] private GameObject _registerPanel;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void Start()
    {
        ShowLogin();
    }

    public void ShowLogin()
    {
        _loginPanel.SetActive(true);
        _registerPanel.SetActive(false);
    }

    public void ShowRegister()
    {
        _loginPanel.SetActive(false);
        _registerPanel.SetActive(true);
    }
}
