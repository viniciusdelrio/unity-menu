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
            OptionsController.OnFontSizeValueChanged.AddListener(HandleFontSizeValueChanged);
        }

        private void OnDisable()
        {
            OptionsController.OnFontSizeValueChanged.RemoveListener(HandleFontSizeValueChanged);
        }

        public void HandleFontSizeValueChanged(float fontSize) => 
            customizedText.fontSize = fontSize;
    }
}