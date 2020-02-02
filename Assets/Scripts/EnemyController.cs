using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Vector2 _velocity;

    private Transform _targetTransform;
    public Transform startTransform;
    public Transform endTransform;
    public float enemyHealth = 20f;
    public AudioSource sound;
    
    private void Start()
    {
        _targetTransform = endTransform;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _targetTransform.position, Time.deltaTime);

        if (transform.position.x == endTransform.position.x)
        {
            _targetTransform = startTransform;
            transform.eulerAngles = new Vector3(0, 180, 0);
            sound.Play(0);
        } else if (transform.position.x == startTransform.position.x)
        {
            _targetTransform = endTransform;
            transform.eulerAngles = new Vector3(0, 0, 0);
            sound.Play(0);
        }

        
       
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            enemyHealth--; 
        }

        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }   
    }
}