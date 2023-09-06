using MyFirsProjectManagers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyFirstProjectUIs
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartButtonClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        public void ExitButtonClicked()
        {
            GameManager.Instance.Exit();
        }
    }
}
