using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotator : MonoBehaviour
{
    public float rotationSpeed = 10f; // Velocidad de rotación ajustable

    void Update()
    {
        GameObject[] planets = GameObject.FindGameObjectsWithTag("planets");

        foreach (GameObject planet in planets)
        {
            planet.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}

