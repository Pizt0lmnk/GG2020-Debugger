using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerSpeechboxEvent : MonoBehaviour
{
    public UnityEvent triggerEvent;

    void OnTriggerEnter2D(Collider2D other)
    {
        triggerEvent.Invoke();
        gameObject.SetActive(false);
    }
}
