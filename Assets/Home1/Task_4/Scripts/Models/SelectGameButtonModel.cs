using UnityEngine.UI;
using System;

namespace Task4.Scripts.Models.WinPatterns {
    public class SelectGameButtonModel {
        public event Action<IWinPattern> OnSelectWinPattern;
        private readonly IWinPattern _winPattern;

        public SelectGameButtonModel(Button button, IWinPattern winPattern) {
            _winPattern = winPattern;
            button.onClick.AddListener(SelectWinPattern);
        }

        private void SelectWinPattern() {
            OnSelectWinPattern?.Invoke(_winPattern);
        }
    }
}