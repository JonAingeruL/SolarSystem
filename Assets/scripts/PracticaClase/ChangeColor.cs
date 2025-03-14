using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color myColor = Color.blue;
    private Color LastColourUsed = Color.blue;
    MeshRenderer MyMaterial;
    // Start is called before the first frame update
    void Start()
    {
        MyMaterial= gameObject.GetComponent<MeshRenderer>();
       //gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (LastColourUsed != myColor)
        {
            gameObject.GetComponent<MeshRenderer>().material.color= myColor;
        }
    }
}
