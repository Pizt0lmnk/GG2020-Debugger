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
	public Rigidbody2D Rigidbody2D { get; set; }
	public float speed;

	public readonly PlayerMoveRightState PlayerMoveRightState = new PlayerMoveRightState();
	public readonly PlayerMoveLeftState PlayerMoveLeftState = new PlayerMoveLeftState();
	public readonly PlayerDuckState PlayerDuckState = new PlayerDuckState();
	public readonly PlayerIdleState PlayerIdleState = new PlayerIdleState();
	public readonly PlayerJumpState PlayerJumpingState = new PlayerJumpState();

	private Animator _animator;
	
	private Vector2 _velocity;

	#endregion

	#region Unity Cycles
    private void Start()
    {
	    _animator = GetComponent<Animator>();
	    Rigidbody2D = GetComponent<Rigidbody2D>();
		TransitionToState(PlayerIdleState);
	}
	
	private void Update()
	{
		CurrentState.Update(this);

		if (CurrentState != PlayerDuckState)
		{
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

	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		CurrentState.OnCollisionEnter(this);
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
