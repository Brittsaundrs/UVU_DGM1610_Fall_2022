using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent;

    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        
        // checks if not == null, then get its id
        if (tempObj == null) 
            return;

        var otherID = tempObj.idObj; 
        
        // if we make a match, invoke matchEvent
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else //invoke noMatchEvent
        {
            noMatchEvent.Invoke();
        }
    }
}
