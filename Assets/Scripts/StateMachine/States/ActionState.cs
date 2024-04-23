using UnityEngine;

namespace StateMachine.States
{
    public abstract class ActionState : IState
    {
        protected readonly IStateSwitcher StateSwitcher;
        protected readonly Character Character;

        protected float Timeout;
        private float _totalTime;

        protected ActionState(IStateSwitcher stateSwitcher, Character character)
        {
            StateSwitcher = stateSwitcher;
            Character = character;
        }

        public void Exit()
        {
            _totalTime = 0;
        }

        public void Update()
        {
            
            _totalTime += Time.deltaTime;

            if (_totalTime < Timeout)
            {
                return;
            }

            MoveToNextPlace();
        }

        public abstract void Enter();
        protected abstract void MoveToNextPlace();
    }
}