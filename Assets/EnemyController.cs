using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Events;
using UnityEngine;
using UnityEngine.Events;

public class EnemyController : MonoBehaviour
{
    private Vector2 _velocity;

    private Transform _targetTransform;
    public Transform startTransform;
    public Transform endTransform;
    private UnityEvent unityEvent;

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
        } else if (transform.position.x == startTransform.position.x)
        {
            _targetTransform = endTransform;
        }
        
        UnityEventTools.RemovePersistentListener(unityEvent, 0);
    }
}