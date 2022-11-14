using UnityEngine;
using UnityEngine.Events;

public class TriggerEventsBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEneter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
