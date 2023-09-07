using MyFirstProjectInputs;
using MyFirsProjectMovements;
using UnityEngine;
using MyFirsProjectManagers;

namespace MyFirsProjectControllers
{
    public class PlayerController : MonoBehaviour
    {
        DefaultInput _input;
        bool _canForceUp;
        bool _canMove;
        float _leftRight;
        Mover _mover;
        Rotater _rotater;
        Fuel _fuel;

        public bool CanMove => _canMove;

        private void Start()
        {
            _canMove = true;
        }

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotater = new Rotater(this);
            _fuel = GetComponent<Fuel>();
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnEventTriggered;
            GameManager.Instance.OnMissionSucced += HandleOnEventTriggered;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnEventTriggered;
            GameManager.Instance.OnMissionSucced -= HandleOnEventTriggered;
        }

        private void Update()
        {
            if (!_canMove) return;

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

        private void HandleOnEventTriggered()
        {
            _canMove = false;
            _canForceUp = false;
            _leftRight = 0f;
            _fuel.FuelIncrease(0f);
        }
    }
}
