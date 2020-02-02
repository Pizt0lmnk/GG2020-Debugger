using UnityEngine;

namespace States
{
    public class PlayerDeadState : PlayerBaseState
    {
        public override void EnterState(CharacterController2D player)
        {
            player.transform.position = player.originalPos;
            player.TransitionToState(player.PlayerIdleState);
            player.health++;
        }
        

        public override void Update(CharacterController2D player)
        {
            
        }

        public override void OnCollisionEnter(CharacterController2D player, Collision2D other)
        {
           
        }
    }
}
    