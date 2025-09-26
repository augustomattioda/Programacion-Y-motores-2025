using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : entity
{
    
    [Header("Physics")]
    [SerializeField] private float _jumpforce = 5.0f;
   
    [Header("input")]
    [SerializeField] private KeyCode jumpkey = KeyCode.Space;

    private bool _isgrounded = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 30)
        {
            _isgrounded = true;
        }
    }

    public movement playermovement;
    public direction playerdirection;

    public override void die()
    {
      
    }
  

    private void Start()
    {
       playermovement = new movement(transform, _movespeed, _rb, _jumpforce, _animation, _isgrounded);
       playerdirection = new direction(playermovement);
    }

    private void Update()
    {
       playerdirection.onUpdate();
    }
    private void FixedUpdate()
    {
       playerdirection.onfixedupdate(); 
    }

}
