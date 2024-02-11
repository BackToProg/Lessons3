using UnityEngine;

namespace SecondExample.Scripts
{
    public class Enemy : MonoBehaviour
    {
        private int _health;
        private float _speed;

        public virtual void Initialize(int helath, float speed)
        {
            _health = helath;
            _speed = speed;

            Debug.Log($"��: {_health}, ��������: {_speed}");
        }  
    
        public void MoveTo(Vector3 position) => transform.position = position;
    }
}
