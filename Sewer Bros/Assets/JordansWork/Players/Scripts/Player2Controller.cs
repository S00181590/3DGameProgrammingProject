using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public float speed = 1.5f;

    float horizontal, vertical;

    public bool wantsCarry, pickup;

    public GameObject trigger;

    // Start is called before the first frame update
    void Start()
    {
        wantsCarry = false;
        pickup = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(wantsCarry)
        {
            trigger.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Insert))
            {
                wantsCarry = !wantsCarry;
                trigger.SetActive(false);
            }
        }
        else if(pickup)
        {
            horizontal = Input.GetAxis("ArrowH") * speed * Time.deltaTime;
            vertical = Input.GetAxis("ArrowV") * speed * Time.deltaTime;

            transform.Translate(new Vector3(horizontal, 0, vertical));
        }
        else
        {
            horizontal = Input.GetAxis("ArrowH") * speed * Time.deltaTime;
            vertical = Input.GetAxis("ArrowV") * speed * Time.deltaTime;

            transform.Translate(new Vector3(horizontal, 0, vertical));

            if(Input.GetKeyDown(KeyCode.Insert))
            {
                wantsCarry = !wantsCarry;
            }
        }
        
    }
}
