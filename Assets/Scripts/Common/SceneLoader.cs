using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceDefender
{
    public class SceneLoader : MonoBehaviour
    {
        public void ReloadScene() => LoadScene(SceneManager.GetActiveScene().name);
        public void LoadMainScene() => LoadScene(SceneNames.MainScene);
        public void LoadGameScene() => LoadScene(SceneNames.GameScene);

        private void LoadScene(string sceneName) => SceneManager.LoadScene(sceneName);
    }
}
