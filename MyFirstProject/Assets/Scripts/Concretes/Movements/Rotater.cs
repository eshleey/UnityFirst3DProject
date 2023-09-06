using System.Collections;
using System.Collections.Generic;
using MyFirsProjectControllers;
using UnityEngine;

namespace MyFirsProjectMovements
{
    public class Rotater
    {
        Rigidbody _rigidbody;
        PlayerController _playerController;

        public Rotater(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody = _playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick(float direction)
        {
            if( direction == 0 )
            {
                if (_rigidbody.freezeRotation) _rigidbody.freezeRotation = false;
                return;
            }

            if( !_rigidbody.freezeRotation ) _rigidbody.freezeRotation = true;

            _playerController.transform.Rotate(Vector3.back * Time.deltaTime * direction * 45f); 
        }
    }
}
