using System.Collections;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public string myName;

    // Start is called before the first frame update
    void Start()
    {
     Debug.Log("I am alive and my name is " + myName);   
    }
}
