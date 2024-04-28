using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float botBound = -10f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound )
        {
            Destroy(this.gameObject);
            
        }

        if (transform.position.z < botBound)
        {
            Debug.Log("¡¡¡Game over!!!");
            Time.timeScale = 0;
            Destroy(this.gameObject);
        }
    }
}
