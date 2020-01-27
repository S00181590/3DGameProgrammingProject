//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Playermovemnt : MonoBehaviour
//{

//    public GameObject playerPrefab;
//    List<GameObject> players = new List<GameObject>();
//   public  float speed = 6.0f;
//    public float jumpheight = 6.0f;
//    public float gravity = 10f;
//    private Vector3 moveDirection = Vector3.zero;



//     void Update()
//      {
//        CharacterController controller = GetComponent<CharacterController>();
//        if (controller.isGrounded)
//        {
//            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
//            moveDirection = transform.TransformDirection(moveDirection);
//            moveDirection *= speed;

//            if (Input.GetButton("jump"))
//                moveDirection.y = jumpheight;
//        }

//        moveDirection.y -= gravity * Time.deltaTime;

//        controller.Move(moveDirection * Time.deltaTime);
//        //foreach (GameObject player in GameObject.FindObjectOfType (typeof(GameObject)))
//        //{
//        //    if (player.tag == "Player" && !player.Contains(player))
//        //        players.Add(player);
//        //}

//        ////player one 
//        //if (Input.GetKey(KeyCode.A))
//        //    players[0].transform.Translate(Vector3.left * speed * Time.deltaTime);
//        //if (Input.GetKey(KeyCode.D))
//        //    players[0].transform.Translate(Vector3.right * speed * Time.deltaTime);
//        //if (Input.GetKey(KeyCode.W))
//        //    players[0].transform.Translate(Vector3.up * speed * Time.deltaTime);
//        //if (Input.GetKey(KeyCode.S))
//        //    players[0].transform.Translate(Vector3.down * speed * Time.deltaTime);

//        ////player 2
//        //if (Input.GetKey(KeyCode.LeftArrow))
//        //    players[1].transform.Translate(Vector3.left * speed * Time.deltaTime);
//        //if (Input.GetKey(KeyCode.RightArrow))
//        //    players[1].transform.Translate(Vector3.right * speed * Time.deltaTime);
//        //if (Input.GetKey(KeyCode.UpArrow))
//        //    players[1].transform.Translate(Vector3.up * speed * Time.deltaTime);
//        //if (Input.GetKey(KeyCode.DownArrow))
//        //    players[1].transform.Translate(Vector3.down * speed * Time.deltaTime);
//    }
//}
