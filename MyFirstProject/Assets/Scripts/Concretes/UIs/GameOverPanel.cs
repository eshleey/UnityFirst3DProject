using MyFirsProjectManagers;
using UnityEngine;

namespace MyFirstProjectUIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButtonClicked()
        {
            GameManager.Instance.LoadLevelScene();
            SoundManager.Instance.PlaySound(5);
        }

        public void NoButtonClicked()
        {
            GameManager.Instance.LoadMenuScene();
            SoundManager.Instance.PlaySound(5);
        }
    }
}
