using UnityEngine;
using System.Collections;

public class InvokeScript : MonoBehaviour 
{
    public bool UseConstant;
    public float ConstantValue;
    public FloatData Variable;

    public float Value 
    {
        get {return UseConstant ? ConstantValue : Variable.value;}
    }
    public GameObject target;    

    void Start()
    {
        Invoke ("SpawnObject", 2);
    }
    
    void SpawnObject()
    {
        Instantiate(target, new Vector3(0, 2, 0), Quaternion.identity);
    }
}