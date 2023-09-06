using MyFirsProjectManagers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyFirstProjectUIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButtonClicked()
        {
            GameManager.Instance.LoadLevelScene();
        }

        public void NoButtonClicked()
        {
            GameManager.Instance.LoadMenuScene();
        }
    }
}
