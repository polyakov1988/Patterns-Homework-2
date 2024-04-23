using System;
using UnityEngine;

namespace StateMachine.States
{
    public class MovingState : IState
    {
        private const float MinDistance = 0.001f;
        
        private readonly IStateSwitcher _stateSwitcher;
        private readonly Character _character;
        private Action _switchState;
        private Transform _target;
        
        public MovingState(IStateSwitcher stateSwitcher, Character character)
        {
            _stateSwitcher = stateSwitcher;
            _character = character;
        }
        
        public void Enter()
        {
            _target = _character.NextPlace;
            _character.SleepStarted += OnSleepStarted;
            _character.WorkStarted += OnWorkStarted;
        }

        public void Exit()
        {
            _target = null;
            _character.SleepStarted -= OnSleepStarted;
            _character.WorkStarted -= OnWorkStarted;
        }

        public void Update()
        {
            _character.transform.position = Vector3.MoveTowards(_character.transform.position, _target.position,
                _character.Config.MovingStateConfig.Speed * Time.deltaTime);

            if (Vector3.Distance(_character.transform.position, _target.position) <= MinDistance)
            {
                _switchState();
            }
        }

        private void OnSleepStarted()
        {
            _switchState = () => _stateSwitcher.SwitchState<SleepingState>();
            
        }
        
        private void OnWorkStarted()
        {
            _switchState = () => _stateSwitcher.SwitchState<WorkingState>();
        }
    }
}