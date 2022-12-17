using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wings2 : MonoBehaviour
{
    Animator Anim;
    void Start()
    {
        string info = "[n] = play, [b] = playbackwards, [m] = stop";
        print(info);

        Anim = GetComponent<Animator>();
        Anim.SetFloat("Dir", 0f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            print("play");

            Anim.SetFloat("Dir", 1.0f);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            print("play backwards");

            Anim.SetFloat("Dir", -1.0f);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            print("stop");

            Anim.SetFloat("Dir", 0.0f);
        }
    }
}