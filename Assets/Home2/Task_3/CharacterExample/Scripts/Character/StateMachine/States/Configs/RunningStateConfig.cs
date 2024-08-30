using System;
using UnityEngine;

[Serializable]
public class RunningStateConfig {
    [field: SerializeField, Range(10, 15)] public float FastRunningSpeed { get; private set; }
    [field: SerializeField, Range(5, 10)] public float RunningSpeed { get; private set; }
    [field: SerializeField, Range(1, 5)] public float WalkingSpeed { get; private set; }
}
