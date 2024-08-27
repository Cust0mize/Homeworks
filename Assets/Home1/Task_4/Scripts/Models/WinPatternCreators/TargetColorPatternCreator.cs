using Task4.Scripts.Models.WinPatterns;
using Random = UnityEngine.Random;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Task_4.Scripts.Models.WinPatternCreators {
    public class TargetColorPatternCreator : IWinPatternCreator {
        public IWinPattern Create(Dictionary<Color, int> balls) {
            int targetColorIndex = Random.Range(0, balls.Count);
            return new TakeTargetColorWinPattern(balls, balls.Keys.ElementAt(targetColorIndex));
        }
    }
}