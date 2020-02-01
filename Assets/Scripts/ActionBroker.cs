using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionBroker : MonoBehaviour
{
    public static event Action PlayerIsJumping;

    public static void CallPlayerIsJumping()
    {
        PlayerIsJumping?.Invoke();
    }

    public static void ClearPlayerIsJumping()
    {
        PlayerIsJumping = null;
    }
}