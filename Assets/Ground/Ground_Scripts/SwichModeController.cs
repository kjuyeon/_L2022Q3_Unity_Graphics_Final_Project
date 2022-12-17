using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwichModeController : MonoBehaviour
{
    public GameObject boat;
    public GameObject boatCamera;
    public GameObject player;
    public GameObject playerStartPos;

    //public Transform playerStartPos1;
    
    // Start is called before the first frame update
    void Start()
    {
               
    }

    Vector3 pos;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad1)||Input.GetKeyDown(KeyCode.Alpha1))
        {
            boat.GetComponent<Rigidbody>().isKinematic = false;
            boat.GetComponent<BoatController>().enabled = true;
            boatCamera.SetActive(true);
            
            player.SetActive(false);
        }

        if(Input.GetKeyUp(KeyCode.Keypad2)||Input.GetKeyUp(KeyCode.Alpha2))
        {
            //pos = playerStartPos.transform.position;
            //player.transform.position = new Vector3(pos.x, pos.y, pos.z);
            player.transform.position = playerStartPos.transform.position;
            boat.GetComponent<Rigidbody>().isKinematic = true;
            boat.GetComponent<BoatController>().enabled = false;
            boatCamera.SetActive(false);

            player.SetActive(true);
            
            print(pos);
            //print(player.transform.position);
        }
    }
}
