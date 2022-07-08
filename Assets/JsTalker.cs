using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class JsTalker : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern string Hello();
    // Start is called before the first frame update
    void Start()
    {
        Hello();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
