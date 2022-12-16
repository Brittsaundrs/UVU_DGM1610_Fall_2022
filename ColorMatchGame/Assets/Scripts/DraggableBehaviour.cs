using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableBehaviour : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position, offset; // gets world space
    
    // Start is called before the first frame update
    void Start()
    {
        cameraObj = Camera.main; // refer to camera info
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToViewportPoint(Input.mousePosition);
        yield return new WaitForFixedUpdate(); // waits for just a half-second until info is collected
        draggable = true; // set draggable to true

        while (draggable) // while it's true...
        {
            yield return new WaitForFixedUpdate(); // give it a sec

            // changes Vector3 position
            position = cameraObj.ScreenToViewportPoint(Input.mousePosition) - offset;
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
