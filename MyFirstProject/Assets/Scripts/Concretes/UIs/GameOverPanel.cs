using MyFirsProjectManagers;
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
