using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyFirsProject
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
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
