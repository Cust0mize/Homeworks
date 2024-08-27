using Task4.Scripts.Models.WinPatterns;
using System.Collections.Generic;
using Task_4.Scripts.Behaviours;
using UnityEngine;
using System;

namespace Task_4.Scripts.Models.WinPatternCreators {
    public class WinPatternCreatorManager {
        public event Action<IWinPattern[], Action<IWinPattern>> OnWinPatternsCreate;

        private readonly SelectGameTypeButtonContainer _selectGameTypeButtonContainer;
        private readonly IWinPatternCreator[] _winPatternCreators;
        private List<IWinPattern> _winPatterns = new();

        public WinPatternCreatorManager(
        SelectGameTypeButtonContainer selectGameTypeButtonContainer,
        IWinPatternCreator[] winPatternCreators
        ) {
            _selectGameTypeButtonContainer = selectGameTypeButtonContainer;
            _winPatternCreators = winPatternCreators;
        }

        public void CreateWinPatterns(Dictionary<Color, int> balls, Action<IWinPattern> selectWinPattern) {
            for (int i = 0; i < _winPatternCreators.Length; i++) {
                _winPatterns.Add(_winPatternCreators[i].Create(balls));
            }

            _selectGameTypeButtonContainer.InitButton(_winPatterns.ToArray(), selectWinPattern);
        }
    }
}