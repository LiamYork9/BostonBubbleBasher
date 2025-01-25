using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StateMachine
{
    public class SM_StateMachine : MonoBehaviour
    {
        protected State m_state = null;

        [HideInInspector]
        public List<State> states;
        public string stateName;

        private void SetState(State _state)
        {
            if (states == null)
                return;
            if(states != null)
            {
                m_state.stateExited.Invoke();
                m_state.OnExit();
            }

            m_state = _state;
            m_state.stateMachine = this;
            m_state.stateStart.Invoke();
            m_state.OnStart();
            stateName = m_state.GetType().ToString();
        }

        public void ChangeState(string _stateName)
        {
            foreach (State s in states)
            {
                if(_stateName.ToLower() == s.GetType().ToString().ToLower())
                {
                    SetState(s);
                    return;
                }
            }

            Debug.LogWarning(_stateName + " not found.");
        }

        public void FixedUpdate()
        {
            if (m_state == null)
                return;
            m_state.UpdateState(Time.fixedDeltaTime);
        }
    }
}
