using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.Windows;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] float torqueAmout = 1f;
    [SerializeField] float speedBoost = 1f;
    [SerializeField] float bastSpeed = 2f;
    Rigidbody2D rb2d;
    SurfaceEffector2D serfaceEffector;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        serfaceEffector = FindObjectOfType<SurfaceEffector2D>();
    }


    void Update()
    {
        Rotation();
        RespondToBoost();
    }

    private void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            serfaceEffector.speed = speedBoost;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            serfaceEffector.speed = bastSpeed;
        }
    }

    private void Rotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmout);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmout);
        }
    }
}
