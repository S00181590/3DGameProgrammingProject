using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public float speed = 2f;

    float horizontal, vertical;

    public bool CanHit, CanCarry;

    // Start is called before the first frame update
    void Start()
    {
        CanHit = false;
        CanCarry = false;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("WASDH") * speed * Time.deltaTime;
        vertical = Input.GetAxis("WASDV") * speed * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0, vertical));
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
