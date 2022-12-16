using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_SwitchController : MonoBehaviour
{
    public GameObject DomeLightCover;
    public GameObject DomeLight1;
    public GameObject DomeLight2;
    bool isActive1 = false;
    bool isActive2 = false;
    public Material MatOn, MatOff;
    Material[] Materials;

    private void Start()
    {
        DomeLight1.SetActive(false);
        DomeLight2.SetActive(false);
        Materials = DomeLightCover.GetComponent<Renderer>().materials;
        print(Materials.Length);
        Materials[1] = MatOff;
        DomeLightCover.GetComponent<Renderer>().materials = Materials;
    }
    private void OnMouseDown()
    {
        isActive1 = !isActive1;
        isActive2 = !isActive2;
        DomeLight1.SetActive(isActive1);
        DomeLight2.SetActive(isActive2);

        if (isActive1)
        {
            Materials[1] = MatOn;
            DomeLightCover.GetComponent<Renderer>().materials = Materials;
        }
        else
        {
            Materials[1] = MatOff;
            DomeLightCover.GetComponent<Renderer>().materials = Materials;
        }
    }
}
