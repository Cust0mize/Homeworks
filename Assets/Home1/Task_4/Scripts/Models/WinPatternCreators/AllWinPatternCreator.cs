using Task4.Scripts.Models.WinPatterns;
using System.Collections.Generic;
using UnityEngine;

namespace Task_4.Scripts.Models.WinPatternCreators {
    public class AllWinPatternCreator : IWinPatternCreator {
        public IWinPattern Create(Dictionary<Color, int> balls) {
            return new TakeAllWinPattern(balls);
        }
    }
}