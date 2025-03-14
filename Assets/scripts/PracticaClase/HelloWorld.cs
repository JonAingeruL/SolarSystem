using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Message with a GameObject name.
        Debug.Log("Hola soy " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        //BreakPoint();
    }

    private void BreakPoint()
    {
        Debug.Log("El " + gameObject.name + " dice Hola 1");
        Debug.Log("El " + gameObject.name + " dice Hola 2");
        Debug.Log("El " + gameObject.name + " dice Hola 3");
    }
}
