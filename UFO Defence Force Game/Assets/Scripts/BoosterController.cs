using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterController : MonoBehaviour

{
    public float verticalInput;
    public Transform booster;
    public GameObject boost; 
    // Have booster randomly pop up
    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
    	// gets a key binding, better than GetKey

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Create boost at booster transform position maintaining object rotation
            Instantiate(boost, booster.transform.position, boost.transform.rotation);
        }
    }
} 
