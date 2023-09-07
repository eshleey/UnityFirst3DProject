using MyFirsProjectManagers;
using MyFirstProjectUIs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyFirsProjectControllers
{
    public class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player != null )
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}
