using UnityEngine;
using TMPro;

public class TextManager: MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI inputText;
    [SerializeField] private TextMeshProUGUI finalText;

    public void LoadText()
    {
        finalText.text = inputText.text;
    }
}