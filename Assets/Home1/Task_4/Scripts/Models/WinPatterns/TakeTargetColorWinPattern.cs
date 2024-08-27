using Task_4.Scripts.Models.BallModels;
using System.Collections.Generic;
using UnityEngine;

namespace Task4.Scripts.Models.WinPatterns {
    public class TakeTargetColorWinPattern : IWinPattern {
        public string PatternDescription => string.Format("Собери шары {0} цвета", _targetColor);
        //До последнего думал что юнити умеет в color.Name, а оказывается это из стандартной библиотеки свойство...

        private Dictionary<Color, int> _balls;
        private Color _targetColor;
        public TakeTargetColorWinPattern(Dictionary<Color, int> balls, Color color) {
            _balls = balls;
            _targetColor = color;
        }
        public void TryWin(BaseBallModel baseBallModel) {
            if (baseBallModel.BallColor == _targetColor) {
                _balls[_targetColor]--;
                if (_balls[_targetColor] == 0) {
                    Debug.Log("Win!");
                }
            }
        }
    }
}