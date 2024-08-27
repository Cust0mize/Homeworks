using Task_3.Scripts.Models;
using UnityEngine;
using Zenject;

namespace Task_3.Scripts.Behaviours {
    public class InputManager : MonoBehaviour {
        private ReputationModel _reputationModel;

        [Inject]
        private void Inject(ReputationModel reputationModel) {
            _reputationModel = reputationModel;
        }

        void Update() {
            if (Input.GetKeyDown(KeyCode.UpArrow)) {
                _reputationModel.AddReputation(5f);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow)) {
                _reputationModel.AddReputation(-5f);
            }
        }
    }
}