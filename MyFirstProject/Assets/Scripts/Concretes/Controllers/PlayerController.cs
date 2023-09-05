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
        float _leftRight;
        Mover _mover;
        Rotater _rotater;

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotater = new Rotater(this);
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

            _leftRight = _input.LeftRight;
        }

        private void FixedUpdate()
        {
            if( _isForceUp )
            {
                _mover.FixedTick();
            }

            _rotater.FixedTick(_leftRight);
        }
    }
}
