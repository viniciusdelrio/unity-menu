using MyMenu.Events;
using UnityEngine;

namespace MyMenu
{
    public class OptionsController : MonoBehaviour
    {
        public static FloatEvent OnFontSizeChanged = new FloatEvent();
        public static ColorEvent OnFontColorChanged = new ColorEvent();

        public void OnFontSize_ValueChanged(float size) => 
            OnFontSizeChanged.Invoke(size);

        public void OnFontColor_ValueChanged(Color color) =>
            OnFontColorChanged.Invoke(color);
    }
}