using Home2.Task_2.Scripts.Models.WorkPatterns;
using UnityEngine.UI;
using UnityEngine;
using Zenject;

public class ButtonRoot : MonoBehaviour {
    [SerializeField] private Button _easyWorkButton;
    [SerializeField] private Button _averageWorkButton;
    [SerializeField] private Button _hardWorkButton;
    private WorkPatternSwitcher _workPatternSwitcher;

    [Inject]
    private void Inject(WorkPatternSwitcher workPatternSwitcher) {
        _workPatternSwitcher = workPatternSwitcher;
    }

    public void Init() {
        _averageWorkButton.onClick.AddListener(() => _workPatternSwitcher.SetNewCurrentPattern<AverageWork>());
        _easyWorkButton.onClick.AddListener(() => _workPatternSwitcher.SetNewCurrentPattern<EasyWork>());
        _hardWorkButton.onClick.AddListener(() => _workPatternSwitcher.SetNewCurrentPattern<HardWork>());
    }

    private void OnDestroy() {
        _averageWorkButton.onClick.RemoveAllListeners();
        _easyWorkButton.onClick.RemoveAllListeners();
        _hardWorkButton.onClick.RemoveAllListeners();
    }
}
