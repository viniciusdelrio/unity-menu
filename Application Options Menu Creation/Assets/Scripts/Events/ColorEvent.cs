using System;
using UnityEngine;
using UnityEngine.Events;

namespace MyMenu.Events
{
    [Serializable]
    public class ColorEvent : UnityEvent<Color>
    { }
}