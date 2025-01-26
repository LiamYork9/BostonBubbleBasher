using StateMachine;
using UnityEngine;

[System.Serializable]
public class Kick : SM_State
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override void UpdateState(float _dt)
    {
        base.UpdateState(_dt);
        ((BIGMANStateMachine)stateMachine).mKick();

    }
    public override void OnExit()
    {
        base.OnExit();
        ((BIGMANStateMachine)stateMachine).kickHB.SetActive(false);
        ((BIGMANStateMachine)stateMachine).ranKick += 1; 
        ((BIGMANStateMachine)stateMachine).curPoint = ((BIGMANStateMachine)stateMachine).points[0];
    }
}
