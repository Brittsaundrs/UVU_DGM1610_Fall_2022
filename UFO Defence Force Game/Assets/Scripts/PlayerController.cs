using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// namespaces & libraries

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 25;
    public float xRange = 30;
    public Transform blaster;
    public GameObject laserbolt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Set horizontalInput to receive values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
    	    // gets a key binding, better than GetKey
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
            /* transform.Translate moves object left/right 
            time.deltaTime keeps it constant regardless of GPU by connecting
            it to time(seconds)*/
        // Keep player withing bounds (left)
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //If spacebar pressed create laserbolt
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Create laserbolt at blaster transform position maintaining object rotation
            Instantiate(laserbolt, blaster.transform.position, laserbolt.transform.rotation);
        }
    }
}