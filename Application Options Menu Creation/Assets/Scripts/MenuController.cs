using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyMenu
{
    public class MenuController : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private TextMeshProUGUI gameTitle;
        [SerializeField] private RectTransform menuOptions;
        [SerializeField] private GameObject optionsPanel;

        [Header("Tween Parameters")]
        [SerializeField] private float gameTitleFadeDuration = 2.0f;
        [SerializeField] private float gameTitleTweenStartDelay = 1.0f;
        [SerializeField] private float menuOptionsMoveDuration = 1.0f;
        [SerializeField] private float menuOptionsTweenStartDelay = 2.0f;

        private void Start()
        {
            gameTitle.DOFade(1.0f, gameTitleFadeDuration)
                     .From(0.0f)
                     .SetDelay(gameTitleTweenStartDelay);

            menuOptions.DOAnchorPos(menuOptions.anchoredPosition, menuOptionsMoveDuration)
                       .From(new Vector2(657, -25))
                       .SetDelay(menuOptionsTweenStartDelay);
        }

        public void Play() =>
            SceneManager.LoadSceneAsync("Game Scene");

        public void ToggleOptions() =>
            optionsPanel.SetActive(!optionsPanel.activeSelf);

        public void Quit() =>
            Application.Quit();
    }
}