using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour
{
    public GameObject gamaobjact;
    private void Start()
    {
        gamaobjact.transform.position = new Vector3(0, 1, 0);
    }
}
