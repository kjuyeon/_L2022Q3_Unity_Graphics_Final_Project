using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wings : MonoBehaviour
{
    Animator Anim;
    void Start()
    {
        string info = "[j] = play, [k] = play 2x, [l] = stop";
        print(info);

        Anim = GetComponent<Animator>();
        Anim.speed = 0.0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            print("play");

            Anim.speed = 1.0f;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            print("play backwards");

            Anim.speed = 2.0f;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            print("stop");

            Anim.speed = 0;
        }
    }
}
