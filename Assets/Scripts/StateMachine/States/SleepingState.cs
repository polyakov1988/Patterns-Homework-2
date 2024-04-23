namespace StateMachine.States
{
    public class SleepingState : ActionState
    {
        public SleepingState(IStateSwitcher stateSwitcher, Character character) : base(stateSwitcher, character) { }

        public override void Enter()
        {
            Timeout = Character.Config.SleepingStateConfig.Timeout;
        }
        
        protected override void MoveToNextPlace()
        {
            StateSwitcher.SwitchState<MovingState>();
        }
    }
}