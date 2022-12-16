using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableBehaviour : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position, offset; // gets world space
    private Vector3 screenPoint, currentScreenPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        cameraObj = Camera.main; // refer to camera info
    }

    public IEnumerator OnMouseDown()
    {
        screenPoint  = Camera.main.WorldToScreenPoint(transform.position);
        //offset = transform.position - cameraObj.ScreenToViewportPoint(Input.mousePosition);
        offset = transform.position - cameraObj.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        draggable = true; // set draggable to true
        yield return new WaitForFixedUpdate(); // waits for just a half-second until info is collected

        while (draggable) // while it's true...
        {
            yield return new WaitForFixedUpdate(); // give it a sec
            currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

            // changes Vector3 position
            position = cameraObj.ScreenToWorldPoint(currentScreenPoint) + offset;
            transform.position = position; // feeds info to transform value
        }
    }

    private void OnMouseUp()
    {
        // stop changing position when mouse isn't on obj
        // also stops OnMouseDown overall
        draggable = false; 
    }
}
