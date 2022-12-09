using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
/* Note: Coroutines can only live inside a MonoBehaviour, cannot
be put into a ScriptableObject parent*/
{
    public UnityEvent repeatEvent;
    public int counterNum = 5;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;
    // These will help keep RAM storage free
    // Start is called before the first frame update
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();

        while (counterNum > 0)
        {
            Debug.Log(counterNum);
            yield return wfsObj;
            repeatEvent.Invoke();
            counterNum--; // counterNum now behaves as countdown
        }
    }
}
