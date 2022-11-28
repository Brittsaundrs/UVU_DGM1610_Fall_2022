using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public GameObject boost;
    public int BoostersPickedUp = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == boost)
        {
            BoostersPickedUp++;
        }
        else
        {
            Destroy(gameObject);
            //Destroy(other.gameObject);
        }
    }
}
