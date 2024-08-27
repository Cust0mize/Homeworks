using UnityEngine;

namespace Task_3.Scripts.Models.TradingPatterns {
    public class NoTrade : ITradingPattern {
        public TradingPatternType TradingPatternType => TradingPatternType.None;

        public void Trade() {
            Debug.Log("Мы не торгуем");
        }
    }
}