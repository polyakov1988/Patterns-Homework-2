using System.Collections.Generic;
using System.Linq;
using StateMachine.States;

namespace StateMachine
{
    public class CharacterStateMachine : IStateSwitcher
    {
        private readonly List<IState> _states;
        private IState _currentState;

        public CharacterStateMachine(Character character)
        {
            _states = new List<IState>()
            {
                new MovingState(this, character),
                new SleepingState(this, character),
                new WorkingState(this, character)
            };

            _currentState = _states[0];
            _currentState.Enter();
        }
        
        public void SwitchState<T>() where T : IState
        {
            IState state = _states.First(state => state is T);

            _currentState.Exit();
            _currentState = state;
            _currentState.Enter();
        }

        public void Update() => _currentState.Update();
    }
}