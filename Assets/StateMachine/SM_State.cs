using UnityEngine;

namespace StateMachine
{
    [System.Serializable]
    public class State
    {
        private bool m_isActive = false;

        [SerializeField]
        public OnStateStart stateStart;
        [SerializeField]
        public OnStateExit stateExited;

        [HideInInspector]
        public SM_StateMachine stateMachine;

        public virtual void OnStart()
        {
            m_isActive = true;
        }

        public virtual void UpdateState(float _dt)
        {
            if (!m_isActive)
                return;
        }

        public virtual void OnExit()
        {
            if(!m_isActive)
                return;
            m_isActive = false;
        }
    }
    [System.Serializable]
    public class OnStateStart : UnityEngine.Events.UnityEvent { }
    [System.Serializable]
    public class OnStateExit : UnityEngine.Events.UnityEvent { }

}
