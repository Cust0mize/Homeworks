using Task4.Scripts.Models.WinPatterns;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using TMPro;

namespace Task_4.Scripts.Behaviours {
    public class SelectGameTypeButtonContainer : MonoBehaviour {
        [SerializeField] private Button[] _selectGameTypeButtons;
        private List<SelectGameButtonModel> _selectGameButtons = new();
        private Action<IWinPattern> _selectWinPattern;
        private IWinPattern[] _winPatterns;

        public void InitButton(IWinPattern[] winPatterns, Action<IWinPattern> selectWinPattern) {
            _selectWinPattern = selectWinPattern;
            _winPatterns = winPatterns;

            for (int i = 0; i < _winPatterns.Length; i++) {
                _selectGameTypeButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = _winPatterns[i].PatternDescription;
                SelectGameButtonModel selectGameButton = new(_selectGameTypeButtons[i], winPatterns[i]);
                selectGameButton.OnSelectWinPattern += SelectWinPattern;
                _selectGameButtons.Add(selectGameButton);
            }
        }

        private void SelectWinPattern(IWinPattern winPattern) {
            for (int i = 0; i < _selectGameTypeButtons.Length; i++) {
                _selectGameTypeButtons[i].onClick.RemoveAllListeners();
                _selectGameButtons[i].OnSelectWinPattern -= SelectWinPattern;
            }

            gameObject.SetActive(false);
            _selectWinPattern?.Invoke(winPattern);
        }
    }
}