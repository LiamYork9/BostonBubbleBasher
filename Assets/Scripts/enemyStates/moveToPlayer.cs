using Pathfinding;
using StateMachine;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class moveToPlayer : SM_State
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override void UpdateState(float _dt)
    {
        base.UpdateState(_dt);
        if (((enemyStateMachiene)stateMachine).isWaiting == true)
        {
            ((enemyStateMachiene)stateMachine).ChangeState(nameof(waitinZone));
        }
    }
    public override void OnExit()
    {
        base.OnExit();
        
    }

    
}
