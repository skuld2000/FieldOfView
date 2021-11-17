using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.DrawLine(Vector3.one * 5f, Vector3.zero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
