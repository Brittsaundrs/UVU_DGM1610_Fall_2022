using UnityEngine;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value;
    public void UpdateValue(float num)
    {
        value  += num;
    }
}

// cool thing is float data can be shared w/any scene!