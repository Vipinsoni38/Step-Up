﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolderScript : MonoBehaviour
{
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;       
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            transform.position = player.position;
        }        
    }
}
