namespace StateMachine.States
{
    public class WorkingState : ActionState
    {
        public WorkingState(IStateSwitcher stateSwitcher, Character character) : base(stateSwitcher, character) { }
        
        public override void Enter()
        {
            Timeout = Character.Config.WorkingStateConfig.Timeout;
        }
        
        protected override void MoveToNextPlace()
        {
            StateSwitcher.SwitchState<MovingState>();
        }
    }
}