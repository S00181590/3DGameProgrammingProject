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
            transform.Translate(
                new Vector3(
                    transform.position.x, 
                    transform.position.y + 5f, 
                    transform.position.z));

        }
        else
        {
            transform.Translate(startPosition);
        }
    }
}
