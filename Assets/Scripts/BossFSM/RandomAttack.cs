using StateMachine;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

[System.Serializable]
public class RandomAttack : SM_State
{
    public override void OnStart()
    {
        base.OnStart();
    }
    public override void UpdateState(float _dt)
    {
        base.UpdateState(_dt);
        
        ((BIGMANStateMachine)stateMachine).transform.position = Vector2.MoveTowards(((BIGMANStateMachine)stateMachine).transform.position, ((BIGMANStateMachine)stateMachine).curPoint.position, ((BIGMANStateMachine)stateMachine).speed * Time.deltaTime);
        if(((BIGMANStateMachine)stateMachine).moveCounter == 0)
        {
            ((BIGMANStateMachine)stateMachine).randPoint = Random.Range(0, 4);
            ((BIGMANStateMachine)stateMachine).ranKick = Random.Range(1, ((BIGMANStateMachine)stateMachine).kickChance);
        }
        if(((BIGMANStateMachine)stateMachine).moveCounter < 2)
        {        
            if (Vector2.Distance(((BIGMANStateMachine)stateMachine).transform.position, ((BIGMANStateMachine)stateMachine).curPoint.position) < .2f && ((BIGMANStateMachine)stateMachine).curPoint == ((BIGMANStateMachine)stateMachine).points[0])
            {
                ((BIGMANStateMachine)stateMachine).curPoint = ((BIGMANStateMachine)stateMachine).points[4];

            }
            if (Vector2.Distance(((BIGMANStateMachine)stateMachine).transform.position, ((BIGMANStateMachine)stateMachine).curPoint.position) < .2f && ((BIGMANStateMachine)stateMachine).curPoint == ((BIGMANStateMachine)stateMachine).points[4])
            {
                ((BIGMANStateMachine)stateMachine).curPoint = ((BIGMANStateMachine)stateMachine).points[0];
                ((BIGMANStateMachine)stateMachine).moveCounter++;
            }
        }
        else
        {
            ((BIGMANStateMachine)stateMachine).Shoot(((BIGMANStateMachine)stateMachine).points[((BIGMANStateMachine)stateMachine).randPoint]);
            
            
            if (((BIGMANStateMachine)stateMachine).ranKick == ((BIGMANStateMachine)stateMachine).kickNum)
            {
                ((BIGMANStateMachine)stateMachine).ChangeState(nameof(Kick));
            }
        }
    }
    public override void OnExit()
    {
        base.OnExit();
    }
}