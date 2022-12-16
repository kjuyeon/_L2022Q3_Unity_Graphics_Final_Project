using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    Animator Anim;
    void Start()
    {
        string info = "[p] = play, [s] = stop";
        print(info);

        Anim = GetComponent<Animator>();
        Anim.speed = 0.5f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            print("play");
            Anim.speed = 0.5f;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            print("stop");
            Anim.speed = 0f;
        }
    }
}
