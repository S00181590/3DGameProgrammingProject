using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public float speed = 0.5f;

    float horizontal, vertical;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("WASDH") * speed * Time.deltaTime;
        vertical = Input.GetAxis("WASDV") * speed * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0, vertical));
    }
}
