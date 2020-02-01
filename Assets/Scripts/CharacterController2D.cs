using System;
using System.Collections;
using System.Collections.Generic;
using States;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[RequireComponent(typeof(Animator))]
public class CharacterController2D : MonoBehaviour
{
	#region Variables
	private PlayerBaseState CurrentState { get; set; }

	public float Movement { get; set; }
	public bool Jump { get; set; }
	public float speed;

	public readonly PlayerMoveRightState PlayerMoveRightState = new PlayerMoveRightState();
	public readonly PlayerMoveLeftState PlayerMoveLeftState = new PlayerMoveLeftState();
	public readonly PlayerIdleState IdleState = new PlayerIdleState();

	private Animator _animator;
	private Rigidbody2D _rigidbody2D;
	
	private Vector2 _velocity;

	#endregion

	#region Unity Cycles
    private void Start()
    {
	    _animator = GetComponent<Animator>();
	    _rigidbody2D = GetComponent<Rigidbody2D>();
		TransitionToState(IdleState);
	}
	
	private void Update()
	{
		CurrentState.Update(this);
		Movement = Input.GetAxisRaw("Horizontal");
		
		float moveInput = Input.GetAxisRaw("Horizontal");
		
		float acceleration = 75;
		
		float deceleration = 70;

		if (moveInput != 0)
		{
			_velocity.x = Mathf.MoveTowards(_velocity.x, speed * moveInput, acceleration * Time.deltaTime);
		}
		else
		{
			_velocity.x = Mathf.MoveTowards(_velocity.x, 0, deceleration * Time.deltaTime);
		}
		
		transform.Translate(_velocity * Time.deltaTime);


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
