using UnityEngine;
using TMPro;

public class DialoguePanel : MonoBehaviour
{
    public static DialoguePanel Instance;

    [SerializeField] private GameObject panel;
    [SerializeField] private TMP_Text dialogueText;

    private int index;
    private string[] sentences;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        panel.SetActive(false);
    }

    public void ShowDialogue(string[] sentences)
    {
        this.sentences = sentences;
        index = 0;
        panel.SetActive(true);
        NextSentence();
    }

    public void NextSentence()
    {
        if (index < sentences.Length)
        {
            dialogueText.text = sentences[index];
            index++;
        }
        else
        {
            Close();
        }
    }

    public void Close()
    {
        panel.SetActive(false);
    }
}
