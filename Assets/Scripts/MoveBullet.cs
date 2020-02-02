using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    private Vector2 _velocity;

    // Update is called once per frame
    void Update()
    {
        _velocity.x = Mathf.MoveTowards(_velocity.x, 5, 75 * Time.deltaTime);
        transform.Translate(_velocity * Time.deltaTime);
    }
}
