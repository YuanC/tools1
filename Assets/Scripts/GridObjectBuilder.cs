using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridObjectBuilder : MonoBehaviour
{
    public List<GameObject> PrefabList;
    public int x = 0;
    public int y = 0;
    private int ListIndex = 0;

    public void BuildObject()
    {
        Instantiate(PrefabList[ListIndex], new Vector3(0, 0, 0), Quaternion.identity);
    }
}   
