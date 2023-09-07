using MyFirsProjectManagers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyFirstProjectUIs
{
    public class WinConditionPanel : MonoBehaviour
    {
        public void YesButtonClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        public void NoButtonClicked()
        {
            GameManager.Instance.LoadMenuScene();
        }
    }
}
