using UnityEngine;

namespace States
{
    public class PlayerIdleState : PlayerBaseState
    {
        public override void EnterState(CharacterController2D player)
        {
            player.SetAnimation("PlayerIdle");
        }

        public override void Update(CharacterController2D player)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                player.TransitionToState(player.PlayerJumpingState);
            }
            else if (player.Movement < 0)
            {
                player.TransitionToState(player.PlayerMoveLeftState);
            }
            else if (player.Movement > 0)
            {
                player.TransitionToState(player.PlayerMoveRightState);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                player.TransitionToState(player.PlayerDuckState);
            }
        }

        public override void OnCollisionEnter(CharacterController2D player)
        {
        }
    }
}