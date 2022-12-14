using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
/* Note: Coroutines can only live inside a MonoBehaviour, cannot
be put into a ScriptableObject parent*/
{
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;

    public bool canRun;
    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;
    // These will help keep RAM storage free
    // Start is called before the first frame update
    
    private void Start()
    {
        startEvent.Invoke();
    }
    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
    private IEnumerator Counting()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        startCountEvent.Invoke();
        yield return wfsObj;
        while (counterNum.value > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.value--; // counterNum now behaves as countdown
            yield return wfsObj;
        }
        endCountEvent.Invoke();
    }

    private IEnumerator RepeatUntilFalse()
    {
        while (canRun)
        {
            yield return wfsObj;
            repeatUntilFalseEvent.Invoke();
        }
    }

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }
}
