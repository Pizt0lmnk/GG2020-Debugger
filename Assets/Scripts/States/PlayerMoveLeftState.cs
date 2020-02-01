using UnityEngine;

namespace States
{
    public class PlayerMoveLeftState : PlayerBaseState
    {
        public override void EnterState(CharacterController2D player)
        {
            player.SetAnimation("PlayerLeft");
        }

        public override void Update(CharacterController2D player)
        {
            if (Input.GetButtonDown("Jump"))
            {
                player.TransitionToState(player.PlayerJumpingState);
            }
            else if (player.Movement == 0)
            {
                player.TransitionToState(player.PlayerIdleState);
            }
            else if (player.Movement > 0)
            {
                player.TransitionToState(player.PlayerMoveRightState);
            }
        }

        public override void OnCollisionEnter(CharacterController2D player)
        {
        }
    }
}