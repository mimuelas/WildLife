using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float coldown=0;
    private float timeColdown = 1;

    // Update is called once per frame
    void Update()
    {

        coldown += Time.deltaTime;
        if (coldown > timeColdown)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                  
                coldown = 0;
            }       
        }
      

    }
}
