using UnityEngine;

namespace States
{
    public class PlayerMoveRightState : PlayerBaseState
    {
        public override void EnterState(CharacterController2D player)
        {
            player.SetAnimation("PlayerRight");
        }

        public override void Update(CharacterController2D player)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                player.TransitionToState(player.PlayerJumpingState);
            }
            else if (player.Movement == 0)
            {
                player.TransitionToState(player.PlayerIdleState);
            }
            else if (player.Movement < 0)
            {
                player.TransitionToState(player.PlayerMoveLeftState);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                player.TransitionToState(player.PlayerDuckState);
            }
        }

        public override void OnCollisionEnter(CharacterController2D player, Collision2D other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                player.health--;
            }
           
            if (player.health <=0 )
            {
                player.TransitionToState(player.PlayerDeadState);
            }
        }
    }
}