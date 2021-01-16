using MyMenu.Events;
using UnityEngine;

namespace MyMenu
{
    public class OptionsController : MonoBehaviour
    {
        public static FloatEvent OnFontSizeValueChanged = new FloatEvent();

        public void OnFontSize_ValueChanged(float value) => 
            OnFontSizeValueChanged.Invoke(value);
    }
}