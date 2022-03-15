﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private GameObject player = null;
    private Vector3 position_offset = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.FindGameObjectWithTag("Player");

        this.position_offset = this.transform.position - this.player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 new_position = this.transform.position;

        new_position.x = this.player.transform.position.x + this.position_offset.x;

        this.transform.position = new_position;
    }
}
