﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialObject : MonoBehaviour
{
    public int Id {get; private set;}
    public int Quantity { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        Id = 1;
        Quantity = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
