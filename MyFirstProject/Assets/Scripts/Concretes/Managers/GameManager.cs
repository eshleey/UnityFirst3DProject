using MyFirsProjectAbstractUtilities;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyFirsProjectManagers
{
    public class GameManager : SingletonThisObject<GameManager>
    {
        public event System.Action OnGameOver;
        public event System.Action OnMissionSucced;

        private void Awake()
        {
            SingletonThisGameObject(this);
        }

        public void GameOver()
        {
            OnGameOver?.Invoke();
            SoundManager.Instance.PlaySound(4);
        }

        public void MissionSucced()
        {
            OnMissionSucced?.Invoke();
            SoundManager.Instance.PlaySound(3);
        }

        public void LoadLevelScene(int LevelIndex = 0)
        {
            StartCoroutine(LoadLevelSceneAsync(LevelIndex));
        }

        private IEnumerator LoadLevelSceneAsync(int LevelIndex)
        {
            SoundManager.Instance.StopSound(1);
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + LevelIndex);
            SoundManager.Instance.PlaySound(2);
        }

        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }

        private IEnumerator LoadMenuSceneAsync()
        {
            SoundManager.Instance.StopSound(2);
            yield return SceneManager.LoadSceneAsync("Menu");
            SoundManager.Instance.PlaySound(1);
        }

        public void Exit()
        {
            Debug.Log("Exit process on triggered");
            Application.Quit();
        }
    }
}
