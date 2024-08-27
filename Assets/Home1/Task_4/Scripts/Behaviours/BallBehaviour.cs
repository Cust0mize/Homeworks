using Task_4.Scripts.Models.BallModels;
using UnityEngine.EventSystems;
using UnityEngine;
using System;

namespace Task_4.Scripts.Behaviours {
    public class BallBehaviour : MonoBehaviour, IPointerClickHandler {
        [SerializeField] private Material _material;
        public event Action<BaseBallModel> OnBallClick;
        private BaseBallModel _ballModel;

        public void Init(BaseBallModel baseBallModel) {
            _material = new(_material);
            GetComponent<Renderer>().material = _material;
            _ballModel = baseBallModel;
            _material.color = _ballModel.BallColor;
        }

        public void OnPointerClick(PointerEventData eventData) {
            OnBallClick?.Invoke(_ballModel);
            Destroy(gameObject);
        }
    }
}