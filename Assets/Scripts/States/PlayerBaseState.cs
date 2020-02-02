using UnityEngine;

namespace States
{
    public abstract class PlayerBaseState
    {
        public abstract void EnterState(CharacterController2D player);

        public abstract void Update(CharacterController2D player);
        
        public abstract void OnCollisionEnter(CharacterController2D player, Collision2D other);
    }
}