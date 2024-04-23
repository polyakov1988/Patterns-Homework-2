using System;
using StateMachine;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private CharacterConfig _config;
    [SerializeField] private Transform _sleepTransform;
    [SerializeField] private Transform _workTransform;

    private Transform _nextPlace;
    private CharacterStateMachine _stateMachine;

    public event Action SleepStarted;
    public event Action WorkStarted;

    public CharacterConfig Config => _config;
    public Transform NextPlace => _nextPlace;

    private void Awake()
    {
        _nextPlace = _workTransform;
        _stateMachine = new CharacterStateMachine(this);
    }
    
    private void Update()
    {
        _stateMachine.Update();
    }

    public void Sleep()
    {
        SleepStarted?.Invoke();
        _nextPlace = _workTransform;
    }
    
    public void Work()
    {
        WorkStarted?.Invoke();
        _nextPlace = _sleepTransform;
    }
}