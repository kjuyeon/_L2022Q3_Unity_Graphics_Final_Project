using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_MovingWall : MonoBehaviour
{
    public GameObject Pivot1;

    private void OnTriggerEnter(Collider other)
    {
        print("enter " + other.name);
        Pivot1.GetComponent<Animator>().SetInteger("State", 1);
    }

    private void OnTriggerExit(Collider other)
    {
        print("exit " + other.name);
        Pivot1.GetComponent<Animator>().SetInteger("State", 2);
    }
}
