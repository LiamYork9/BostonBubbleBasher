using StateMachine;
using UnityEngine;

[System.Serializable]

public class attack : SM_State
{
    public float attackRate = .5f;
    public float nextAttack = -1.0f;
    public bool canAttack = true;
    public override void OnStart()
    {
        base.OnStart();
        Debug.Log("Attacking");
        
        nextAttack = Time.time + attackRate;
        ((enemyStateMachiene)stateMachine).isAttacking = true;

    }
    public override void UpdateState(float _dt)
    {
        base.UpdateState(_dt);
        
        if (Time.time > nextAttack)
        {
            canAttack = true;
        }
        if(canAttack)
        {
            ((enemyStateMachiene)stateMachine).Attack();
            nextAttack = Time.time + attackRate;
            canAttack = false;
            ((enemyStateMachiene)stateMachine).ChangeState(nameof(moveToPlayer));
        }
    }
    
    public override void OnExit()
    {
        base.OnExit();
        ((enemyStateMachiene)stateMachine).isAttacking = false;
    }
}

