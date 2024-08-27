using UnityEngine;

namespace Task_3.Scripts.Models.TradingPatterns {
    public class TradeFruit : ITradingPattern {
        public TradingPatternType TradingPatternType => TradingPatternType.Fruit;

        public void Trade() {
            Debug.Log("Мы торгуем фруктами");
        }
    }
}