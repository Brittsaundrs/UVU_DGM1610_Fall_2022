using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;
    public void CreateInstance ()
    {
        Instantiate(prefab);
    }

    public void CreateInstance (Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList (Vector3DataList obj)
    {
        foreach (Vector3Data v in obj.vector3List)
        {
            Instantiate(prefab, v.value, Quaternion.identity);   
        }
    }

    public void CreateInstanceFromListCounting (Vector3DataList obj)
    {
        Instantiate(prefab, obj.vector3List[num].value, Quaternion.identity);
        num++;
        if (num == obj.vector3List.Count)
        {
            num = 0;
        }
    }
}
