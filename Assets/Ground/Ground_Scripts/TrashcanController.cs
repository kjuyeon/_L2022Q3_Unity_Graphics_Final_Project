using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashcanController : MonoBehaviour
{   
    public GameObject Pivot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        Pivot.GetComponent<Animator>().SetInteger("Can", 1);
        Debug.Log("Clicked");
    }
}
