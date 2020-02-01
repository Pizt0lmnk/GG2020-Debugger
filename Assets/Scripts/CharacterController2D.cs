using System;
using System.Collections;
using System.Collections.Generic;
using States;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class CharacterController2D : MonoBehaviour
{
	#region Variables
	private PlayerBaseState CurrentState { get; set; }

	public float Movement { get; set; }

	public readonly PlayerMoveRightState PlayerMoveRightState = new PlayerMoveRightState();
	public readonly PlayerMoveRightState IdleState = new PlayerMoveRightState();

	private Animator _animator;
	
	#endregion

	#region Unity Cycles
    private void Start()
    {
	    _animator = GetComponent<Animator>();
		TransitionToState(IdleState);
	}
	
	private void Update()
	{
		CurrentState.Update(this);
		Movement = Input.GetAxisRaw("Horizontal");
	}
	
	#endregion

	#region State Logic
	public void SetAnimation(string playerAnimation)
	{
		_animator.Play(playerAnimation);
	}
	
	public void TransitionToState(PlayerBaseState state)
	{
		CurrentState = state;
		CurrentState.EnterState(this);
	}
	#endregion

}
