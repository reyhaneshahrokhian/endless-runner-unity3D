using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    public Text Pause;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Backspace))
        {
            Pause.text = "click Tab to continue!!";
        }
        if (Input.GetKey(KeyCode.Tab))
        {
            Pause.text = " ";
        }
    }
}
