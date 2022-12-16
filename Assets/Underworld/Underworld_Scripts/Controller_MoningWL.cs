using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_MoningWL : MonoBehaviour
{
    public GameObject Pivot2;

    private void OnTriggerEnter(Collider other)
    {
        print("enter " + other.name);
        Pivot2.GetComponent<Animator>().SetInteger("State", 1);
    }

    private void OnTriggerExit(Collider other)
    {
        print("exit " + other.name);
        Pivot2.GetComponent<Animator>().SetInteger("State", 2);
    }
}
