using System;
using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehaviour : MonoBehaviour
{
    public ID idObj;
    public UnityEvent startEvent;
    public Animation UpScale;

    public void Start()
    {
        startEvent.Invoke();
    }

    private void OnTriggerEnter()
    {
        UpScale.Play();
    }
}
