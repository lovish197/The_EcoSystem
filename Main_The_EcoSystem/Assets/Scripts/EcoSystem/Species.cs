using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LA.Framework;


namespace EcoSystem
{
    public class Species : MonoBehaviour
    {
        [SerializeField] protected Vector m_Acceleration;
        [SerializeField] protected Vector m_Velocity;

        private void Update()
        {
            OnUpdate();
        }
        private void OnDestroy()
        {
            OnDestroy_();
        }
        public virtual void Initalize()
        {
            m_Velocity.Add(m_Acceleration);
            OnInitialize();
        }

        public virtual void OnUpdate() { }
        public virtual void OnDestroy_() { }
        public virtual void OnInitialize() { }
    }
}
