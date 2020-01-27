using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public bool IsOpen;

    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        IsOpen = false;
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(IsOpen)
        {
            transform.position =
                new Vector3(
                    transform.position.x, 
                    15f, 
                    transform.position.z);

        }
        else
        {
            if(transform.position != startPosition)
            {
                transform.position = startPosition;
            }
            
        }
    }
}
