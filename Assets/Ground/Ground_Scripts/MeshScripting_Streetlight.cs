using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshScripting_Streetlight : MonoBehaviour
{
    Vector3 V0, V1, V2, V3, V4, V5, V6, V7, V8, V9, V10, V11;
    Vector3[] newVertices;
    int[] newTriangles;
    Vector3[] newNormals;

    // Start is called before the first frame update
    void Start()
    {
        V0 = new Vector3(-0.25f, -5f, -0.25f);
        V1 = new Vector3(-0.25f, -5f, 0.25f);
        V2 = new Vector3(0.25f, -5f, 0.25f);
        V3 = new Vector3(0.25f, -5f, -0.25f);
        V4 = new Vector3(-0.25f, 5f, -0.25f);
        V5 = new Vector3(-0.25f, 5f, 0.25f);
        V6 = new Vector3(0.25f, 5f, 0.25f);
        V7 = new Vector3(0.25f, 5f, -0.25f);
        V8 = new Vector3(1.25f, 4.8f, -0.25f);
        V9 = new Vector3(1.25f, 4.8f, 0.25f);
        V10 = new Vector3(0.25f, 4.8f, 0.25f);
        V11 = new Vector3(0.25f, 4.8f, -0.25f);

        newVertices = new Vector3[]
        {
            // Back
            V0, V4, V7, V3, //0, 1, 2, 3
            
            // Right
            V3, V7, V6, V2, //4, 5, 6, 7

            // Front
            V2, V6, V5, V1, //8, 9, 10, 11

            // Left
            V1, V5, V4, V0, //12, 13, 14, 15

            // Top
            V4, V5, V6, V7, //16, 17, 18, 19

            // Bottom
            V0, V1, V2, V3, //20, 21, 22, 23

            V7, V6, V9, V8,

            V11, V7, V8,

            V10, V6, V9,

            V11, V10, V9, V8
        };

        newTriangles = new int[]
        {
            // Back
            0, 1, 2,
            0, 2, 3,

            // Right
            4, 5, 7,
            7, 5, 6,
            //4, 5, 6,
            //4, 6, 7,

            // Front
            8, 9, 11,
            11, 9, 10,

            // Left
            12, 13, 14,
            12, 14, 15,

            // Top
            16, 17, 18,
            16, 18, 19,

            // Bottom
            21, 20, 23,
            21, 23, 22,

            24, 25, 26,
            24, 26, 27,

            28, 29, 30,

            31, 33, 32,

            34, 36, 35,
            34, 37, 36
        };

        Vector3 Up = Vector3.up;
        Vector3 Down = Vector3.down;
        Vector3 Front = Vector3.forward;
        Vector3 Left = Vector3.left;
        Vector3 Right = Vector3.right;
        Vector3 Back = Vector3.back;
        Vector3 Light1 = Vector3.up;
        Vector3 Light2 = Vector3.forward;
        Vector3 Light3 = Vector3.back;
        Vector3 Light4 = Vector3.down;

        newNormals = new Vector3[]
        {
            // Back
            Back, Back, Back, Back,

            // Right            
            Right, Right, Right, Right,

            // Front
            Front, Front, Front, Front,

            // Left
            Left, Left, Left, Left,

            // Top
            Up, Up, Up, Up,

            // Bottom
            Down, Down, Down, Down,

            Up, Up, Up, Up,

            Back, Back, Back,

            Front, Front, Front,

            Down, Down, Down, Down

    };

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = newVertices;
        mesh.triangles = newTriangles;
        mesh.normals = newNormals;

        mesh.RecalculateBounds();
        mesh.Optimize();
        Shader DefaultShader = Shader.Find("Standard");
        Material DefaultMaterial = new Material(DefaultShader);
        gameObject.GetComponent<Renderer>().material = DefaultMaterial;

    }
}