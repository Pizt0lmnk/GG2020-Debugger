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
            if (Input.GetButtonDown("Jump"))
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
        }

        public override void OnCollisionEnter(CharacterController2D player)
        {
        }
    }
}