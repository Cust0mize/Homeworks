using UnityEngine;
using Zenject;

namespace Task_2.Scripts.Behaviours {
    public class ObjectInstallerBehaviour : MonoBehaviour {
        public void InstantiateObject(GameObject targetObject, Vector3 position, Quaternion rotate) {
            Instantiate(targetObject, position, rotate);
        }
    }
}