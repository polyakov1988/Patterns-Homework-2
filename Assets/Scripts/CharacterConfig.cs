using StateMachine.Configs;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private MovingStateConfig _movingStateConfig;
    [SerializeField] private SleepingStateConfig _sleepingStateConfig;
    [SerializeField] private WorkingStateConfig _workingStateConfig;

    public MovingStateConfig MovingStateConfig => _movingStateConfig;
    public SleepingStateConfig SleepingStateConfig => _sleepingStateConfig;
    public WorkingStateConfig WorkingStateConfig => _workingStateConfig;
}
