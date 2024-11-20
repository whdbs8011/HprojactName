using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using Unity.Properties;
using UnityEngine;
using UnityEngine.WSA;
using Object = UnityEngine.Object;

public class move : MonoBehaviour
{
    [SerializeField] float speed=5f; 
    [SerializeField] float mouseSpeed = 8f;
    private float gravity;
    private CharacterController controller;
    private Vector3 mov;
    
    private float mouseX;

    private static move Instance;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (Instance)
        {
            DestroyImmediate(this.gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
        
    }


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        mov = Vector3.zero;
        gravity = 10f;
  
    }

    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * mouseSpeed;
        this.transform.localEulerAngles = new Vector3(0, mouseX, 0);

        if (controller.isGrounded)
        {
            mov = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            mov = controller.transform.TransformDirection(mov);
        }
        else
        {
            mov.y -= gravity * Time.deltaTime;
        }
        
        controller.Move(mov * (Time.deltaTime * speed));
    }
}

