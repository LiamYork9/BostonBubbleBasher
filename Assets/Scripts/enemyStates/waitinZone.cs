using StateMachine;
using UnityEngine;

[System.Serializable]
public class waitinZone : SM_State
{
    public override void OnStart()
    {
        base.OnStart();
        Debug.Log("Waiting");
    }
    public override void UpdateState(float _dt)
    {
        base.UpdateState(_dt);
        if (((enemyStateMachiene)stateMachine).nextInQueue ==  true)
        {
            ((enemyStateMachiene)stateMachine).timer.StartTime();
        }
    }
    public override void OnExit()
    {
        base.OnExit();
        ((enemyStateMachiene)stateMachine).timer.ResetTime();
        ((enemyStateMachiene)stateMachine).isWaiting = false;
    }
}
