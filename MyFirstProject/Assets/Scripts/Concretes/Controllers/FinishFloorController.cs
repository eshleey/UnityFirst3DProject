using MyFirsProjectManagers;
using UnityEngine;

namespace MyFirsProjectControllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject _finishFirework;
        [SerializeField] GameObject _finishLight;

        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player == null || !player.CanMove) return;

            if(other.GetContact(0).normal.y == -1)
            {
                _finishFirework.SetActive(true);
                _finishLight.SetActive(true);
                GameManager.Instance.MissionSucced();
            }
            else
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}
