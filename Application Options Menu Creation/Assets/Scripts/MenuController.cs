using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyMenu
{
    public class MenuController : MonoBehaviour
    {
        [SerializeField] private GameObject optionsPanel;

        public void Play() =>
            SceneManager.LoadSceneAsync("Game Scene");

        public void ToggleOptions() =>
            optionsPanel.SetActive(!optionsPanel.activeSelf);

        public void Quit() =>
            Application.Quit();
    }
}