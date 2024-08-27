using UnityEngine;

namespace Task_3.Scripts.Models {
    public class ReputationModel {
        private readonly Shop _tradingPatternSwitcher;
        private readonly FillImageModel _fillImageModel;
        private float _currentReputation;
        private const float MIN_REPUTATION = 0;
        private const float MAX_REPUTATION = 100;

        public ReputationModel(
        Shop tradingPatternSwitcher,
        FillImageModel fillImageModel
        ) {
            _tradingPatternSwitcher = tradingPatternSwitcher;
            _fillImageModel = fillImageModel;
            UpdateReputation();
        }

        public void AddReputation(float additiveValue) {
            _currentReputation += additiveValue;
            _currentReputation = Mathf.Clamp(_currentReputation, MIN_REPUTATION, MAX_REPUTATION);
            UpdateReputation();
        }

        private void UpdateReputation() {
            _fillImageModel.UpdateFillImage(_currentReputation / MAX_REPUTATION);
            _tradingPatternSwitcher.UpdateTradingPattern(_currentReputation);
            //Мне тут было лень городить обсерверов, поэтому прокинул зависимости напрямую
        }
    }
}