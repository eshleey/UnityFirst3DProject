using MyFirsProjectManagers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyFirsProjectControllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject _finishFirework;
        [SerializeField] GameObject _finishLight;

        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player == null) return;

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
