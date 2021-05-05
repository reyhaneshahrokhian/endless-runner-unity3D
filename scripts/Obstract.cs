using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstract : MonoBehaviour
{
    moves move;
    void Start()
    {
        move = GameObject.FindObjectOfType<moves>();
    }
    void Update()
    {
        
    }

    
/*    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Running")
        {
            move.Die();
        }
    }*/
}
