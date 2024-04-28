using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
         if (!other.CompareTag("Projectile")) return;
        //compruebo si es un proyectil
        Destroy(this.gameObject);
        Destroy(other.gameObject);
    }
}
