using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    public Vector2 junmpForce = new Vector2(0, 5);
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(junmpForce, ForceMode2D.Impulse);
    }

    internal void Die()
    {
        animator.Play("die");
    }
}
