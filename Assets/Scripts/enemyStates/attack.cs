using StateMachine;
using UnityEngine;

[System.Serializable]

public class attack : SM_State
{    public float timeLeft;
    public float attacktime;
    public override void OnStart()
    {
        base.OnStart();
        timeLeft = attacktime;

    }
    public override void UpdateState(float _dt)
    {
        base.UpdateState(_dt);
        if(timeLeft > 0.0f){
            timeLeft -= Time.deltaTime;

            if(timeLeft <= 0.0f){
                ((enemyStateMachiene)stateMachine).Attack(((enemyStateMachiene)stateMachine).damage);
                timeLeft = attacktime;
                ((enemyStateMachiene)stateMachine).ChangeState(nameof(moveToPlayer));
            }
        }
    }
    public override void OnExit()
    {
        base.OnExit();
    }
}
