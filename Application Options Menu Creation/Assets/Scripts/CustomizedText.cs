using TMPro;
using UnityEngine;

namespace MyMenu
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class CustomizedText : MonoBehaviour
    {
        private TextMeshProUGUI customizedText;

        private void Start() => 
            customizedText = GetComponent<TextMeshProUGUI>();

        private void OnEnable()
        {
            OptionsController.OnFontSizeChanged.AddListener(HandleFontSizeChanged);
            OptionsController.OnFontColorChanged.AddListener(HandleFontColorChanged);
        }

        private void OnDisable()
        {
            OptionsController.OnFontSizeChanged.RemoveListener(HandleFontSizeChanged);
            OptionsController.OnFontColorChanged.RemoveListener(HandleFontColorChanged);
        }

        private void HandleFontSizeChanged(float fontSize) => 
            customizedText.fontSize = fontSize;

        private void HandleFontColorChanged(Color fontColor) =>
            customizedText.color = fontColor;
    }
}