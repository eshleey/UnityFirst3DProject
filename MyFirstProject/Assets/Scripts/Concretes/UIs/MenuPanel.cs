using MyFirsProjectManagers;
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
