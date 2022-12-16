using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whale : MonoBehaviour
{
    Animator Anim;

    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.SetFloat("Dir",1.0f);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Anim.SetFloat("Dir", 1.0f);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Anim.SetFloat("Dir", -1.0f);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Anim.SetFloat("Dir", 2.0f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Anim.SetFloat("Dir", 0.0f);
        }
    }
}
