using Task4.Scripts.Models.WinPatterns;
using System.Collections.Generic;
using UnityEngine;

namespace Task_4.Scripts.Models.WinPatternCreators {
    public interface IWinPatternCreator {
        public IWinPattern Create(Dictionary<Color, int> balls);
    }
}