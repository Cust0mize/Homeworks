using Home2.Task_2.Scripts.Models.WorkPatterns;
using UnityEngine.UI;
using UnityEngine;
using Zenject;

public class ButtonRoot : MonoBehaviour {
    private WorkPatternSwitcher _workPatternSwitcher;
    [SerializeField] private Button _easyWorkButton;
    [SerializeField] private Button _averageWorkButton;
    [SerializeField] private Button _hardWorkButton;

    internal void Init() {
        _easyWorkButton.onClick.AddListener(() => _workPatternSwitcher.SetNewCurrentPattern<EasyWork>());
        _averageWorkButton.onClick.AddListener(() => _workPatternSwitcher.SetNewCurrentPattern<AverageWork>());
        _hardWorkButton.onClick.AddListener(() => _workPatternSwitcher.SetNewCurrentPattern<HardWork>());
    }

    [Inject]
    private void Inject(WorkPatternSwitcher workPatternSwitcher) {
        _workPatternSwitcher = workPatternSwitcher;
    }
}
