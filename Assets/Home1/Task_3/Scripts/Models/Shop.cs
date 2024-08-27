using Task_3.Scripts.Models.TradingPatterns;
using System.Collections.Generic;
using System.Linq;

namespace Task_3.Scripts.Models {
    public class Shop {
        private Dictionary<TradingPatternType, ITradingPattern> _tradingPatterns;
        private ITradingPattern _currentTradingPattern;

        public Shop(ITradingPattern[] tradingPatterns) {
            _tradingPatterns = tradingPatterns.ToDictionary(x => x.TradingPatternType);
            _currentTradingPattern = tradingPatterns[0];
        }

        public void UpdateTradingPattern(float currentReputation) {
            if (currentReputation < 20) {
                _currentTradingPattern = _tradingPatterns[TradingPatternType.None];
            }
            else if (currentReputation >= 20 && currentReputation <= 80) {
                _currentTradingPattern = _tradingPatterns[TradingPatternType.Fruit];
            }
            else if (currentReputation > 80) {
                _currentTradingPattern = _tradingPatterns[TradingPatternType.Armor];
            }
        }

        public void Buy() {
            _currentTradingPattern.Trade();
        }
    }
}