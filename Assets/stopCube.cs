﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopCube : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(gameObject.tag == "Block")
        {
            
        }
       gameObject.transform.Translate(0, 0, 0);
    }
}
