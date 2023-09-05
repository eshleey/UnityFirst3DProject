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
        bool _canForceUp;
        float _leftRight;
        Mover _mover;
        Rotater _rotater;
        Fuel _fuel;

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotater = new Rotater(this);
            _fuel = GetComponent<Fuel>();
        }

        private void Update()
        {
            if( _input.IsForceUp && !_fuel.IsEmpty)
            {
                _canForceUp = true;
            }
            else
            {
                _canForceUp = false;
                _fuel.FuelIncrease(0.01f);
            }

            _leftRight = _input.LeftRight;
        }

        private void FixedUpdate()
        {
            if( _canForceUp )
            {
                _mover.FixedTick();
                _fuel.FuelDecrease(0.2f);
            }

            _rotater.FixedTick(_leftRight);
        }
    }
}
