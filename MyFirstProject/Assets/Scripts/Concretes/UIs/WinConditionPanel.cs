using MyFirsProjectManagers;
using UnityEngine;

namespace MyFirstProjectUIs
{
    public class WinConditionPanel : MonoBehaviour
    {
        public void YesButtonClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
            SoundManager.Instance.PlaySound(5);
        }

        public void NoButtonClicked()
        {
            GameManager.Instance.LoadMenuScene();
            SoundManager.Instance.PlaySound(5);
        }
    }
}
