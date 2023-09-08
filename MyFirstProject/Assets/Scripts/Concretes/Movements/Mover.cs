using MyFirsProjectControllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyFirsProjectMovements
{
    public class Mover
    {
        PlayerController _playerController;
        Rigidbody _rigidbody;
        float _moveSpeed;

        public Mover(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody = _playerController.GetComponent<Rigidbody>();
            _moveSpeed = playerController.MoveSpeed;
        }

        public void FixedTick()
        {
            _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * 40f);
        }
    }
}
