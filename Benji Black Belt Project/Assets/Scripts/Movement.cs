﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    [Header("Movement")]
    [Tooltip("Speed of movement")]
    public float speed;
    public enum MovementType
    {
        AllDirections,
        HorizontalOnly,
        VerticalOnly
    }

    [SerializeField]
    private MovementType movementType = 0;

    [Header("Platform Movement")]
    [Tooltip("Adjusts Movement for Platform Games")]
    public bool platformSettings = false;

    private float masterSpeed;




    void Awake()
    {
        masterSpeed = speed;
        print((SceneManager.GetActiveScene()).ToString());
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (platformSettings)
        {
            Rigidbody2D rigidBody;
            rigidBody = GetComponent<Rigidbody2D>();
            float verticalMovement = rigidBody.velocity.y;
            /*if (verticalMovement != 0)
            {
                speed = masterSpeed / 1f;
            }
            else
            {
                speed = masterSpeed;
            }*/
        }

        /*switch (movementType)
        {
            case MovementType.HorizontalOnly:
                vertical = 0f;
                break;
            case MovementType.VerticalOnly:
                horizontal = 0f;
                break;
        }*/

        Vector3 movement = new Vector3(horizontal, 0);

        transform.position += movement * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}

