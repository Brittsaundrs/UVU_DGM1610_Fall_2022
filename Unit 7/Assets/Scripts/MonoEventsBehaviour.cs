using UnityEngine;
using UnityEngine.Events;
/* can help w/controlling score of game
when we start or disable stmh */

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent;
    // three variables declared of the same variable type

    private void Awake()
    {
        awakeEvent.Invoke();
    }
    // Start is called before the first frame update
    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }

    // NEVER put an event inside of update
}