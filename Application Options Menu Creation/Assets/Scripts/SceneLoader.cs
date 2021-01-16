using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyMenu
{
    public class SceneLoader : MonoBehaviour
    {
        public void LoadScene(string sceneName) =>
            SceneManager.LoadScene(sceneName);
    }
}