namespace Task_3.Scripts.Models.TradingPatterns {
    public interface ITradingPattern {
        public TradingPatternType TradingPatternType { get; }
        public void Trade();
    }
}