﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    public GameObject textOne;
    public GameObject textTwo;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(textOne, new Vector3(18f, -3f, 0f), Quaternion.identity);
        Instantiate(textTwo, new Vector3(40f, 9f, 0f), Quaternion.identity);
    }
}
