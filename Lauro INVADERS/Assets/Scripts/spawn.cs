﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public float spawnTime = 2f;
    public float spawnDelay = 2f;
    public GameObject cow;
 
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }
 
    void Spawn()
    {
        /* Instantiate a cow */
 
        GameObject clone = Instantiate(cow, transform.position, transform.rotation) as GameObject;
    }
}
