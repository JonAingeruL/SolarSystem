using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posicion : MonoBehaviour
{
    public bool darPosicion;
    public string nameOb;
    public Object TrackedObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

             Debug.Log("La posicion en X es: " + gameObject.GetComponent<Transform>().position.x +  
                       "La posicion en Y es: " + gameObject.GetComponent<Transform>().position.y + 
                       "La posicion en Z es: " + gameObject.GetComponent<Transform>().position.z);
            
        }
    }
}
