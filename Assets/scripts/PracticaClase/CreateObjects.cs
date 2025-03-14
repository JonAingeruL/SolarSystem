using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CreateObjects : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        CubeSpawner();

    }

    private static void CubeSpawner()
    {
        float offset = 2;
        int maxNumberOfObjects = 100;
        for (int i = 0; i < maxNumberOfObjects; i++)
        {
            GameObject cubito = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubito.AddComponent<Posicion>().TrackedObject = cubito;
            cubito.transform.position = new Vector3(i, i, 0);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
