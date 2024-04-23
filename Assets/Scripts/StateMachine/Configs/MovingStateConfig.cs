using System;
using UnityEngine;

namespace StateMachine.Configs
{
    [Serializable]
    public class MovingStateConfig
    {
        [SerializeField, Min(0)] private float _speed = 5;

        public float Speed => _speed;
    }
}