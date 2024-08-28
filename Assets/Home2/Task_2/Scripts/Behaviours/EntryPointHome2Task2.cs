using Home2.Task_2.Scripts.Models.NPCCustomizers;
using UnityEngine;
using Zenject;

namespace Home2.Task_2.Scripts.Behaviours {
    public class EntryPointHome2Task2 : MonoBehaviour {
        [SerializeField] private NPCController _nPCController;
        private DefaultNPCCustomizer _defaultNPCCustomizer;

        [Inject]
        private void Inject(DefaultNPCCustomizer defaultNPCCustomizer) {
            _defaultNPCCustomizer = defaultNPCCustomizer;
        }


        private void Start() {
            _defaultNPCCustomizer.Customize(_nPCController);
        }
    }
}