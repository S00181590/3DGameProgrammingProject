using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public float speed = 4f;

    float horizontal, vertical;

    public bool wantsCarry,beingCarried, pickup;

    public SphereCollider trigger;

    private Rigidbody rb;

    private GameObject player1;

    // Start is called before the first frame update
    void Start()
    {
        wantsCarry = false;
        pickup = false;
        beingCarried = false;
        rb = gameObject.GetComponent<Rigidbody>();
        trigger = gameObject.GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(wantsCarry)
        {
            trigger.enabled = true;
            

            if (Input.GetKeyDown(KeyCode.RightControl))
            {
                wantsCarry = !wantsCarry;  
            }
        }
        else if(pickup)
        {
            horizontal = Input.GetAxis("ArrowH") * speed * Time.deltaTime;
            vertical = Input.GetAxis("ArrowV") * speed * Time.deltaTime;

            transform.Translate(new Vector3(horizontal, 0, vertical));
        }
        else if(beingCarried)
        {
            gameObject.transform.position = new Vector3(
                    player1.transform.position.x,
                    player1.transform.position.y + 4f,
                    player1.transform.position.z);
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

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player1")
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                gameObject.transform.position = new Vector3(
                    other.transform.position.x,
                    other.transform.position.y + 4f,
                    other.transform.position.z);

                gameObject.transform.SetParent(other.gameObject.transform);

                player1 = other.gameObject;
                beingCarried = true;
               
            }
            
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Acceleration);
        }
    }
}
