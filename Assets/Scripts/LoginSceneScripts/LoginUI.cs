using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LoginUI : MonoBehaviour
{
    [SerializeField] private TMP_InputField _emailInput;
    [SerializeField] private TMP_InputField _passwordInput;

    [SerializeField] private Button _loginButton;
    [SerializeField] private Button _registerButton;

    private AuthManager _authManager;
    private UIManager _uiManager;
    private void OnEnable()
    {
        _loginButton.onClick.AddListener(OnLoginClicked);
        _registerButton.onClick.AddListener(OnGoToRegisterClicked);
        
    }
    private void OnDisable()
    {
        _loginButton.onClick.RemoveAllListeners();
        _registerButton.onClick.RemoveAllListeners();
        
    }
    private void Start()
    {
        _authManager = AuthManager.Instance;
        _uiManager = UIManager.Instance;
    }

    private void OnLoginClicked()
    {
        _authManager.Login(_emailInput.text, _passwordInput.text);
    }

    private void OnGoToRegisterClicked()
    {
        _uiManager.ShowRegister();
    }
}
