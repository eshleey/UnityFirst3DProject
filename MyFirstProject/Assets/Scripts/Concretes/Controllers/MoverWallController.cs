using UnityEngine;

namespace MyFirsProjectControllers
{
    public class MoverWallController : WallController
    {
        [SerializeField] Vector3 _direction;
        [SerializeField] float _factor;
        [SerializeField] float _speed;
        
        const float FULL_CIRCLE = Mathf.PI * 2f;

        Vector3 _startPosition;

        private void Awake()
        {
            _startPosition = transform.position;
        }

        private void Update()
        {
            float cycle = Time.time / _speed;
            float sinWave = Mathf.Sin(cycle * FULL_CIRCLE);
            _factor = Mathf.Abs(sinWave);

            Vector3 offset = _direction * _factor;
            transform.position = offset + _startPosition;
        }
    }
}
