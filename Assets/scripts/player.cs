using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : entity, iaffectedspeed
{
    
    [Header("Physics")]
    [SerializeField] private float _jumpforce = 5.0f;

    [Header("input")]

    [SerializeField] private armas[] weaponsarray;

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
    public attack playerattack;

    public override void die()
    {
      
    }
  

    private void Start()
    {
       playermovement = new movement(transform, _movespeed, _rb, _jumpforce, _animation, _isgrounded);
       playerdirection = new direction(playermovement, _animation);
       playerattack= new attack(weaponsarray, _animation);
    }

    private void Update()
    {
       playerdirection.onUpdate();
       playerattack.Onupdate();
    }
    private void FixedUpdate()
    {
       playerdirection.onfixedupdate(); 
    }

    public void takeSpeed(float spd)
    {
      
    }
    

    public void restoreSpeed(float spd)
    {
        
    }

    
}
