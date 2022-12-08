using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent, startEvent;

    private IEnumerator OnTriggerEnter (Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>(); // Get component
        if (tempObj == null) 
            yield break;
            
        var otherID = tempObj.idObj; 
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
        }
    }
}
