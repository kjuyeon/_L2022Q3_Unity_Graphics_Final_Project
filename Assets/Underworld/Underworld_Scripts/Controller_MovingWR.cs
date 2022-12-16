using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_MovingWR : MonoBehaviour
{
    public GameObject Pivot3;

    private void OnTriggerEnter(Collider other)
    {
        print("enter " + other.name);
        Pivot3.GetComponent<Animator>().SetInteger("State", 1);
    }

    private void OnTriggerExit(Collider other)
    {
        print("exit " + other.name);
        Pivot3.GetComponent<Animator>().SetInteger("State", 2);
    }
}
