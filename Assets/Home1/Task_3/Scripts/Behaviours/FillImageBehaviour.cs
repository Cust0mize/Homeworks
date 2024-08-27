using UnityEngine.UI;
using UnityEngine;

namespace Task_3.Scripts.Behaviours {
    public class FillImageBehaviour : MonoBehaviour {
        [SerializeField] private Gradient _gradient;
        [SerializeField] private Image _parentImage;
        [SerializeField] private Image _fillImage;

        public void UpdateImage(float newValue) {
            _fillImage.fillAmount = newValue;
            _fillImage.color = _gradient.Evaluate(newValue);
        }
    }
}