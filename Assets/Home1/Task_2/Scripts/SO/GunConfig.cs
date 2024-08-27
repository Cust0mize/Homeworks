using Task1.Scripts.Models.GunCreators;
using UnityEngine;

[CreateAssetMenu(fileName = "GunConfig", menuName = "MySo/GunConfig")]
public class GunConfig : ScriptableObject {
    [field: SerializeField] public GunType GunType { get; private set; }
    [field: SerializeField] public int BulletCount { get; private set; }
}
