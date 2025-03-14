using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorWorld : MonoBehaviour
{
    private Object[] objetos;
    public Color color = Color.red;
    public bool findByTag;
    public string choosenTag = "Color";
    // Start is called before the first frame update
    void Start()
    {
        if (findByTag)
        {
            objetos = GameObject.FindGameObjectsWithTag(choosenTag);
        }
        else 
        { 
            objetos = GameObject.FindObjectsOfType<Object>();
        }
}

        // Update is called once per frame
        void Update()
    {
        if (objetos != null)
        {
            foreach (Object item in objetos)
            {
                if (item.GetComponent<MeshRenderer>() != null)
                {
                    item.GetComponent<MeshRenderer>().material.color = color;
                }
                
            }
        }
    }
}
