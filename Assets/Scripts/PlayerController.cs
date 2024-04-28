using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 15.0f;
    public GameObject projectilePrefab;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento del player
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(speed*Time.deltaTime*Vector3.right*horizontalInput);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        //Acciones del player
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Lanzar un proyectil
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }

}
