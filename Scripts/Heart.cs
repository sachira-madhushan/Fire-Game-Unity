﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 45, 0) *2* Time.deltaTime);
        transform.position += Vector3.left * 1 * Time.deltaTime;
    }
}
