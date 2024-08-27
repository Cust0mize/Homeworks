using UnityEngine;

namespace Task_3.Scripts.Models.TradingPatterns {
    public class TradeArmor : ITradingPattern {
        public TradingPatternType TradingPatternType => TradingPatternType.Armor;

        public void Trade() {
            Debug.Log("Мы торгуем броней");
        }
    }
}