using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class CoroutineBehaviour : MonoBehaviour
/* Note: Coroutines can only live inside a MonoBehaviour, cannot
be put into a ScriptableObject parent*/
{
    public UnityEvent startEvent, repeatEvent, endEvent;

    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;
    // These will help keep RAM storage free
    // Start is called before the first frame update
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        startEvent.Invoke();
        yield return wfsObj;
        while (counterNum.value > 0)
        {
            repeatEvent.Invoke();
            counterNum.value--; // counterNum now behaves as countdown
            yield return wfsObj;
        }
        endEvent.Invoke();
    }
}
