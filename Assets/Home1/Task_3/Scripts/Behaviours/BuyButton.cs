using Task_3.Scripts.Models;
using UnityEngine.UI;
using UnityEngine;
using Zenject;

namespace Task_3.Scripts.Behaviours {
    public class BuyButton : MonoBehaviour {
        [SerializeField] private Button _button;
        private Shop _shop;

        [Inject]
        private void Inject(Shop shop) {
            _shop = shop;
        }

        private void Start() {
            _button.onClick.AddListener(_shop.Buy);
        }

        private void OnDestroy() {
            _button.onClick.RemoveAllListeners();
        }
    }
}