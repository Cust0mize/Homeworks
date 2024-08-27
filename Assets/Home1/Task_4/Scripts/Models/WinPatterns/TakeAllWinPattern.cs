using Task_4.Scripts.Models.BallModels;
using System.Collections.Generic;
using UnityEngine;

namespace Task4.Scripts.Models.WinPatterns {
    public class TakeAllWinPattern : IWinPattern {
        private readonly Dictionary<Color, int> _balls;
        private List<bool> _winStates;
        public string PatternDescription => "Собери все шары!";

        public TakeAllWinPattern(Dictionary<Color, int> balls) {
            _balls = balls;
            _winStates = new(_balls.Count);
        }

        public void TryWin(BaseBallModel baseBallModel) {
            _balls[baseBallModel.BallColor]--;

            if (_balls[baseBallModel.BallColor] == 0) {
                _winStates.Add(true);

                if (_winStates.Count == _balls.Count) {
                    Debug.Log("Win!");
                }
            }
        }
    }
}