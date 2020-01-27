using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player2")
        {
            if (Input.GetKeyDown(KeyCode.Insert))
            {
                other.gameObject.GetComponent<Player2Controller>().pickup = true;
                Destroy(gameObject);
            }
        }
    }   
}
