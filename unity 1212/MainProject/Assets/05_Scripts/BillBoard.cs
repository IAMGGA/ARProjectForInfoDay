﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoard : MonoBehaviour {

    public Transform target;

    private void Start()
    {
        target = Camera.main.transform;
    }
    void Update () {
        transform.LookAt(target);
    }
}
