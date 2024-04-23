namespace PLace
{
    public class WorkingPlace : Place
    {
        protected override void DoAction(Character character)
        {
            character.Work();
        }
    }
}