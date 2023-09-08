using MyFirsProjectManagers;
using UnityEngine;

namespace MyFirstProjectUIs
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartButtonClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
            SoundManager.Instance.PlaySound(5);
        }

        public void ExitButtonClicked()
        {
            GameManager.Instance.Exit();
            SoundManager.Instance.PlaySound(5);
        }
    }
}
