using MyFirstProjectInputs;
using MyFirsProjectMovements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyFirsProject
{
    public class PlayerController : MonoBehaviour
    {
        DefaultInput _input;
        bool _isForceUp;
        Mover _mover;

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(GetComponent<Rigidbody>());
        }

        private void Update()
        {
            if( _input.IsForceUp )
            {
                _isForceUp = true;
            }
            else
            {
                _isForceUp = false;
            }
        }

        private void FixedUpdate()
        {
            if( _isForceUp )
            {
                _mover.FixedTick();
            }
        }
    }
}
