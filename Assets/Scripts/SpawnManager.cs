using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    
    public GameObject[] enemies;
    private int animalIndex;
    private float spawnRangeX = 14f;
    
    private float spawnPosZ;

    [SerializeField,Range(2,5)]
    private float spawnDelay = 2f;
    [SerializeField,Range(0.1f,2)]
    private float spawnInterval = 1.5f;

    void Start()
    {
        spawnPosZ = transform.position.z;
        InvokeRepeating("SpawiningEnemies",spawnDelay,spawnInterval);
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawiningEnemies()
    {
        //Generar posicion aleatoria del enemigo
        float xRandom = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPos = new Vector3(xRandom, 0, spawnPosZ);
        animalIndex = Random.Range(0, enemies.Length);
                
        Instantiate(enemies[animalIndex],
            spawnPos,
            enemies[animalIndex].transform.rotation);
        
    }
}

