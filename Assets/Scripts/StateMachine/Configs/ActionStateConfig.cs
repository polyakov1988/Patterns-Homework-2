using System;
using UnityEngine;

namespace StateMachine.Configs
{
    [Serializable]
    public class ActionStateConfig
    {
        [SerializeField, Min(0)] private float _timeout;
        
        public float Timeout => _timeout;
    }
}