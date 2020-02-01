using System.Collections;
using System.Collections.Generic;
using States;
using UnityEngine;

public class PlayerDuckState : PlayerBaseState
{
    public override void EnterState(CharacterController2D player)
    {
        player.SetAnimation("PlayerDuck");
    }

    public override void Update(CharacterController2D player)
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            player.TransitionToState(player.PlayerIdleState);
        }
    }

    public override void OnCollisionEnter(CharacterController2D player)
    {
    }
}
