using UnityEngine;
using TMPro;
using UnityEngine.UI;

/// <summary>
/// Manages all simple UI:
/// - prompt ("Press E to...")
/// - info text (sign/panel messages)
/// - lock panel (code input + confirm button)
/// </summary>
public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [Header("Prompt UI")]
    public GameObject promptPanel;
    public TMP_Text promptText;

    [Header("Info UI")]
    public TMP_Text infoText;

    [Header("Lock Panel UI")]
    public GameObject lockPanel;
    public TMP_InputField codeInputField;
    public Button confirmCodeButton;

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
        if (lockPanel != null)
            lockPanel.SetActive(false);

        if (promptPanel != null)
            promptPanel.SetActive(false);

        if (confirmCodeButton != null)
            confirmCodeButton.onClick.AddListener(OnConfirmCodeClicked);
    }

    public void ShowPrompt(string text)
    {
        if (promptPanel == null || promptText == null) return;
        promptPanel.SetActive(true);
        promptText.text = text;
    }

    public void HidePrompt()
    {
        if (promptPanel == null) return;
        promptPanel.SetActive(false);
    }

    public void ShowInfo(string text)
    {
        if (infoText == null) return;
        infoText.text = text;
    }

    public void ClearInfo()
    {
        if (infoText == null) return;
        infoText.text = "";
    }

    public void OpenLockPanel()
    {
        if (lockPanel == null) return;
        lockPanel.SetActive(true);

        if (codeInputField != null)
        {
            codeInputField.text = "";
            codeInputField.ActivateInputField();
        }
    }

    public void CloseLockPanel()
    {
        if (lockPanel == null) return;
        lockPanel.SetActive(false);
    }

    private void OnConfirmCodeClicked()
    {
        if (codeInputField == null) return;
        string codeString = codeInputField.text;
        Level1PuzzleManager.Instance?.TrySolve(codeString);
    }
}
