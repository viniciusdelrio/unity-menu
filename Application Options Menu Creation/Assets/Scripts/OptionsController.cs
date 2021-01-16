using MyMenu.Events;
using System;
using UnityEngine;

namespace MyMenu
{
    public class OptionsController : MonoBehaviour
    {
        public static FloatEvent OnFontSizeChanged = new FloatEvent();
        public static FloatEvent OnAudioVolumeChanged = new FloatEvent();
        public static ColorEvent OnFontColorChanged = new ColorEvent();
        public static BoolEvent OnThemeChanged = new BoolEvent();

        public void OnFontSize_ValueChanged(float size) => 
            OnFontSizeChanged.Invoke(size);

        public void OnFontColor_ValueChanged(Color color) =>
            OnFontColorChanged.Invoke(color);

        public void OnAudioVolume_ValueChanged(float volume) =>
            OnAudioVolumeChanged.Invoke(volume);

        public void OnTheme_ValueChanged(float theme) =>
            OnThemeChanged.Invoke(Convert.ToBoolean(theme));
    }
}