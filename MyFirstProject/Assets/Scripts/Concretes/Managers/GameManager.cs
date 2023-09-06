using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }
}
