using UnityEngine;

namespace Task_2.Scripts.Behaviours {
    public class BulletBehaviour : MonoBehaviour {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _speed;

        private void Start() {
            _rigidbody.AddForce(transform.forward * _speed);
            //По кису
        }
    }
}