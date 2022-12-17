using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour
{
    Animator Anim;
    void Start()
    { 
        Anim = GetComponent<Animator>();
        Anim.speed = 0.7f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Anim.speed = 0.7f;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Anim.speed = 0f;
        }
    }
}
