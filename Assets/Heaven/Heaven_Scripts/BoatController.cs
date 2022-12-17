using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{

    Animator Anim;
    void Start()
    {
        string info = "[p] = play, [s] = stop";
        print(info);

        Anim = GetComponent<Animator>();
        Anim.speed = 0;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            print("play");
            Anim.speed = 1.0f;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            print("stop");
            Anim.speed = 0f;
        }
    }
}
