using StateMachine;
using UnityEngine;

[System.Serializable]
public class Kick : SM_State
{
    public override void OnStart()
    {
        base.OnStart();
        ((BIGMANStateMachine)stateMachine).curPoint = ((BIGMANStateMachine)stateMachine).player.transform;
        ((BIGMANStateMachine)stateMachine).speed = ((BIGMANStateMachine)stateMachine).speed * 2;
    }
    public override void UpdateState(float _dt)
    {
        base.UpdateState(_dt);
        if (Vector2.Distance(((BIGMANStateMachine)stateMachine).transform.position, ((BIGMANStateMachine)stateMachine).curPoint.position) < 3f)
        {
            ((BIGMANStateMachine)stateMachine).kickHB.active = true;
        }

    }
    public override void OnExit()
    {
        base.OnExit();
    }
}
