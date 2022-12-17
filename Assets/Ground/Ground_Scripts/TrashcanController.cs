using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashcanController : MonoBehaviour
{   
    public GameObject Pivot;
    public GameObject TrashcanPoint;
    AudioSource audioSoure;

    // Start is called before the first frame update
    void Start()
    {
        audioSoure = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        Pivot.GetComponent<Animator>().SetInteger("Can", 1);
        TrashcanPoint.SetActive(false);
        audioSoure.Play();        
    }
    
}