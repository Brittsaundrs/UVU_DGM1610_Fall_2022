using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableBehaviour : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position; // gets world space
    
    // Start is called before the first frame update
    void Start()
    {
        cameraObj = Camera.main; // refer to camera info
    }

    public IEnumerator OnMouseDown()
    {
        draggable = true; // set draggable to true

        while (draggable) // while it's true...
        {
            yield return new WaitForFixedUpdate(); // give it a sec

            // changes Vector3 position
            position = cameraObj.ScreenToViewportPoint(Input.mousePosition);
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
