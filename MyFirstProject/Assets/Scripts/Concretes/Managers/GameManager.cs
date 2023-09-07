using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyFirsProjectManagers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        public event System.Action OnGameOver;
        public event System.Action OnMissionSucced;

        private void Awake()
        {
            SingletonThisGameObject();
        }

        private void SingletonThisGameObject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public void GameOver()
        {
            OnGameOver?.Invoke(); ;
        }

        public void MissionSucced()
        {
            OnMissionSucced?.Invoke();
        }

        public void LoadLevelScene(int LevelIndex = 0)
        {
            StartCoroutine(LoadLevelSceneAsync(LevelIndex));
        }

        private IEnumerator LoadLevelSceneAsync(int LevelIndex)
        {
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + LevelIndex);
        }

        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }

        private IEnumerator LoadMenuSceneAsync()
        {
            yield return SceneManager.LoadSceneAsync("Menu");
        }

        public void Exit()
        {
            Debug.Log("Exit process on triggered");
            Application.Quit();
        }
    }
}
