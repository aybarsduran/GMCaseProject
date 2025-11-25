using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RegisterUI : MonoBehaviour
{
    [SerializeField] private TMP_InputField _emailInput;
    [SerializeField] private TMP_InputField _passwordInput;
    [SerializeField] private TMP_InputField _confirmPasswordInput;

    [SerializeField] private Button _registerButton;
    [SerializeField] private Button _backToLoginButton;

    private AuthManager _authManager;
    private UIManager _uiManager;
    private void OnEnable()
    {
        _registerButton.onClick.AddListener(OnRegisterClicked);
        _backToLoginButton.onClick.AddListener(OnBackToLoginClicked);
        
    }
    private void OnDisable()
    {
        _registerButton.onClick.RemoveAllListeners();
        _backToLoginButton.onClick.RemoveAllListeners();

    }
    private void Start()
    {
        _authManager = AuthManager.Instance;
        _uiManager = UIManager.Instance;
    }
    private void OnRegisterClicked()
    {
        string email = _emailInput.text;
        string pass = _passwordInput.text;
        string confirm = _confirmPasswordInput.text;

        if (pass != confirm)
        {
            Debug.LogError("Passwords do not match!");
            return;
        }

        _authManager.Register(email, pass);
    }

    private void OnBackToLoginClicked()
    {
        _uiManager.ShowLogin();
    }
}
