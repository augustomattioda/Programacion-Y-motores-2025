using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class entity : MonoBehaviour
{

    [Header("Stats")]
    public float vida;
    public float movespeed;

    protected Animator anim;
    protected Rigidbody rb;

    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    public abstract void die();

    public void ApplySpeedModifier(float amount)
    {
        movespeed += amount;
    }

    public void ApplyHealthModifier(float amount)
    {
        vida += amount;
    }

    public void getdamage(float attack)
    {
        vida -= attack;

        if (vida <= 0)
            die();
    }
}

