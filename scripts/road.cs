using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class road : MonoBehaviour
{
    void Start()
    {
        Destroy(this.gameObject,20f);
        Obstacle();
        Obstacle2();
    }
    void Update()
    {
        
    }
    public GameObject obstacle;
    public GameObject obstacle2;
    void Obstacle()
    {
        int Index = Random.Range(2, 5);
        Transform point = transform.GetChild(Index).transform;
        Instantiate(obstacle, point.position, Quaternion.identity, transform);

    }
    void Obstacle2()
    {
        int Index = Random.Range(2, 5);
        Transform point = transform.GetChild(Index).transform;
        Instantiate(obstacle2, point.position, Quaternion.identity, transform);

    }
}
