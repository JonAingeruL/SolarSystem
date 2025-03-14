using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1, gameObject.transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1, gameObject.transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Z))
        {
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x + 1, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, gameObject.transform.localScale.y + 1, gameObject.transform.localScale.z);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, gameObject.transform.localScale.y, gameObject.transform.localScale.z + 1);
        }
    }
}
