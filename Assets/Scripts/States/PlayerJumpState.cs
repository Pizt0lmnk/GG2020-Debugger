using UnityEngine;

namespace States
{
    public class PlayerJumpState : PlayerBaseState
    {
        public override void EnterState(CharacterController2D player)
        {
            player.Rigidbody2D.AddForce(Vector3.up * 250);
        }

        public override void Update(CharacterController2D player)
        {
            if (player.Movement < 0)
            {
                player.SetAnimation("PlayerLeft");
            }
            else if (player.Movement > 0)
            {
                player.SetAnimation("PlayerRight");
            }
        }

        public override void OnCollisionEnter(CharacterController2D player)
        {
            if (player.Movement < 0)
            {
                player.TransitionToState(player.PlayerMoveLeftState);
            }
            else if (player.Movement > 0)
            {
                player.TransitionToState(player.PlayerMoveRightState);
            }
            else
            {
                player.TransitionToState(player.PlayerIdleState);
            }
        }
    }
}
    