﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    private float power;
    public float POWERPLUS = 1000.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetMouseButton(0)){
         power += POWERPLUS * Time.deltaTime;
     }

     if(Input.GetMouseButtonUp(0)){
         this.gameObject.GetComponent<Rigidbody>()
         .AddForce(new Vector3(power,power,0));
         //.AddForce(power,power,0);
         power = 0.0f;
     }

     if(this.transform.position.y < -5.0f) {
         Application.LoadLevel("gameScene");
     }


    }
}
