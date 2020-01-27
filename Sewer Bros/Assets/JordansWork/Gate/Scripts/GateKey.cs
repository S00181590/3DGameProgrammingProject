using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateKey : MonoBehaviour
{
    public bool OnePiece, open;

    public GameObject valve, gate;

    // Start is called before the first frame update
    void Start()
    {
        OnePiece = false;
        open = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(OnePiece)
        {
            valve.SetActive(true);
        }
        else
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
     
            if (other.gameObject.tag == "Player2")
            {
               bool has = other.gameObject.GetComponent<Player2Controller>().pickup;
                if (has)
                {
                    OnePiece = true;
                }
            }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (OnePiece)
        {
            if (other.gameObject.tag == "Player2")
            {
                if (Input.GetKeyDown(KeyCode.Insert))
                {
                    open = !open;
                    gate.GetComponent<Gate>().IsOpen = open;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player2")
        {
            gate.GetComponent<Gate>().IsOpen = false;
        }
    }
}
