﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    private Vector2 _velocity;
    public AudioSource sound; 

    void Start()
    {
        sound.Play(0);
    }
    // Update is called once per frame
    void Update()
    {
        _velocity.x = Mathf.MoveTowards(_velocity.x, 10, 75 * Time.deltaTime);
        transform.Translate(_velocity * Time.deltaTime);
    }
}