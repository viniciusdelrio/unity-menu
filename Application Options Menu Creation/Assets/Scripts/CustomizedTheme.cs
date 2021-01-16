using UnityEngine;
using UnityEngine.UI;

namespace MyMenu
{
    [RequireComponent(typeof(Image))]
    public class CustomizedTheme : MonoBehaviour
    {
        private Image image;

        private readonly Color darkThemeColor = new Color(0.0f, 0.0f, 0.0f, 0.9f);
        private readonly Color lightThemeColor = new Color(0.4f, 0.4f, 0.4f, 0.9f);

        private void Start() => 
            image = GetComponent<Image>();

        private void OnEnable() => 
            OptionsController.OnThemeChanged.AddListener(HandleThemeChanged);

        private void OnDisable() =>
            OptionsController.OnThemeChanged.RemoveListener(HandleThemeChanged);

        private void HandleThemeChanged(bool isLightTheme) =>
            image.color = isLightTheme ? lightThemeColor : darkThemeColor; 
    }
}