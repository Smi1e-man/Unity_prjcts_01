﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorForPlace : MonoBehaviour
{

    [SerializeField] Material _mtrl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<MeshRenderer>().material = _mtrl;
    }

}
