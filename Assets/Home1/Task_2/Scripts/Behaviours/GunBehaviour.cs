using Task_2.Scripts.Models;
using UnityEngine;
using Zenject;

namespace Task_2.Scripts.Behaviours {
    public class GunBehaviour : MonoBehaviour {
        [SerializeField] private Transform _startShootPosition;
        [SerializeField] private BulletBehaviour _bullet;
        private ShootSystem _shootSystem;

        [Inject]
        private void Inject(ShootSystem shootSystem) {
            _shootSystem = shootSystem;
        }

        public void Shoot() {
            _shootSystem.Shoot(_bullet.gameObject, _startShootPosition.position);
        }

        private void Update() {
            if (Input.GetKeyDown(KeyCode.S)) {
                Shoot();
            }
        }
    }
}