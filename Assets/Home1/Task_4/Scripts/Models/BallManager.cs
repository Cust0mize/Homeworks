using Task_4.Scripts.Models.WinPatternCreators;
using Task_4.Scripts.Models.BallModels;
using System.Collections.Generic;
using Task_4.Scripts.Behaviours;
using UnityEngine;
using Zenject;
using System;

namespace Task4.Scripts.Models.WinPatterns {
    public class BallManager : IDisposable, IInitializable {
        private readonly WinPatternCreatorManager _winPatternCreatorManager;
        private readonly BallBehaviour[] _ballBehaviours;
        private readonly BaseBallModel[] _ballModels;
        private IWinPattern _currentWinPattern;

        public BallManager(
        WinPatternCreatorManager winPatternCreatorManager,
        BallBehaviour[] ballBehaviours,
        BaseBallModel[] ballModels
        ) {
            _winPatternCreatorManager = winPatternCreatorManager;
            _ballBehaviours = ballBehaviours;
            _ballModels = ballModels;
        }

        public void Initialize() {
            Dictionary<Color, int> balls = new();

            for (int behavioursIndex = 0, modelIndex = 0; behavioursIndex < _ballBehaviours.Length; behavioursIndex++, modelIndex++) {
                if (modelIndex >= _ballModels.Length) {
                    modelIndex = 0;
                }

                if (balls.TryAdd(_ballModels[modelIndex].BallColor, 1) == false) {
                    balls[_ballModels[modelIndex].BallColor]++;
                }

                _ballBehaviours[behavioursIndex].Init(_ballModels[modelIndex]);
                _ballBehaviours[behavioursIndex].OnBallClick += BallRegistry;
            }

            _winPatternCreatorManager.CreateWinPatterns(balls, SelectWinPattern);
        }

        private void SelectWinPattern(IWinPattern winPattern) {
            _currentWinPattern = winPattern;
        }

        private void BallRegistry(BaseBallModel baseBallModel) {
            _currentWinPattern.TryWin(baseBallModel);
        }

        public void Dispose() {
            for (int behavioursIndex = 0; behavioursIndex < _ballBehaviours.Length; behavioursIndex++) {
                _ballBehaviours[behavioursIndex].OnBallClick -= BallRegistry;
            }
        }
    }
}