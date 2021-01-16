using UnityEngine;

namespace MyMenu
{
    [RequireComponent(typeof(AudioSource))]
    public class CustomizedAudio : MonoBehaviour
    {
        private AudioSource audioSource;

        private void Start() =>
            audioSource = GetComponent<AudioSource>();

        private void OnEnable() =>
            OptionsController.OnAudioVolumeChanged.AddListener(HandleAudioVolumeChanged);

        private void OnDisable() =>
            OptionsController.OnAudioVolumeChanged.RemoveListener(HandleAudioVolumeChanged);

        private void HandleAudioVolumeChanged(float volume) =>
            audioSource.volume = volume;
    }
}