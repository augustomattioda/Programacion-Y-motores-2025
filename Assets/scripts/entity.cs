using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class entity : MonoBehaviour
{
    [Header("Animator")]
    [SerializeField] private string _Xaxis = "Xaxis";
    [SerializeField] private string _Zaxis = "Zaxis";
   

    [SerializeField] protected float vida;

    [Header("Physics")]
    [SerializeField] protected float _movespeed;

    private Vector3 _dir = Vector3.zero;
   

    private bool _isgrounded = true;

    protected Animator _animation;
    protected Rigidbody _rb;

    private void Awake()
    {
        _animation = GetComponentInChildren<Animator>();

        _rb = GetComponent<Rigidbody>();
    }
  
    public abstract void die();

    public void getdamage(float attack) 
    {
        vida -= attack;

        if (vida <= 0) 
        {
            die();
        }
    }
}
