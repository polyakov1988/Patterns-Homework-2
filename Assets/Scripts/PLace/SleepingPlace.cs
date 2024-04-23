namespace PLace
{
    public class SleepingPlace : Place
    {
        protected override void DoAction(Character character)
        {
            character.Sleep();
        }
    }
}