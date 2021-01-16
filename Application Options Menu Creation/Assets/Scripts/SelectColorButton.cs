using UnityEngine;
using UnityEngine.UI;

namespace MyMenu
{
    [RequireComponent(typeof(Button))]
    public class SelectColorButton : MonoBehaviour
    {
        private Button button;
        private OptionsController optionsController;

        private void Start()
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(OnClick);

            optionsController = FindObjectOfType<OptionsController>();
        }

        public void OnClick()
        {
            var color = button.colors.normalColor;
            optionsController.OnFontColor_ValueChanged(color);
        }
    }
}