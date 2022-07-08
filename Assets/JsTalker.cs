using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class JsTalker : MonoBehaviour
{
    // the prototype of getting the component id
    [DllImport("__Internal")]
    private static extern string Hello();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
