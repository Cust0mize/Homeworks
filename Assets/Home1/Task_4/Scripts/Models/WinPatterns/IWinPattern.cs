using Task_4.Scripts.Models.BallModels;

namespace Task4.Scripts.Models.WinPatterns {
    public interface IWinPattern {
        public void TryWin(BaseBallModel baseBallModel);
        public string PatternDescription { get; }
    }
}