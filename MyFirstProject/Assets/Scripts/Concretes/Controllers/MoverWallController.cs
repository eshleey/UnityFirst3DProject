using UnityEngine;

namespace MyFirsProjectControllers
{
    public class MoverWallController : WallController
    {
        [SerializeField] Vector3 _direction;
        [SerializeField] float _directionFactor = 1f;
        [SerializeField] float _speed;
        
        const float FULL_CIRCLE = Mathf.PI * 2f;
        float _factor;

        Vector3 _startPosition;

        private void Awake()
        {
            _startPosition = transform.position;
        }

        private void Update()
        {
            float cycle = Time.time / _speed;
            float sinWave = Mathf.Sin(cycle * FULL_CIRCLE);
            _factor = sinWave / 2f + 0.5f;

            Vector3 offset = _direction * _factor * _directionFactor;
            transform.position = offset + _startPosition;
        }
    }
}
