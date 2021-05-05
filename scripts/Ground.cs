using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject GroundTile;
    Vector3 Next;
    void tile()
    {
        GameObject temp = Instantiate(GroundTile,Next,Quaternion.identity);
        Next = temp.transform.GetChild(1).transform.position;
    }
    void Start()
    {
        InvokeRepeating("tile", 0f, 1.7f);
    }
    void Update()
    {

    }

}
