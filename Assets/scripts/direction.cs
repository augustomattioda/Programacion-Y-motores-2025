using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class direction 
{
    [Header("Animator")]
    [SerializeField] private string IsGrounded = "IsGrounded";
    [SerializeField] private string _Onjump = "_Onjump";

    public movement playermovement;

    private Animator _animation;

    private bool _isgrounded = true;

    KeyCode jumpkey = KeyCode.Space;
    Vector3 _dir;
    public direction(movement m) 
    {
        playermovement = m;
    }
    void jump() 
    {
        playermovement.jump();
    }
    public void onUpdate()
    {
        _dir.x = Input.GetAxis("Horizontal");
      
        _dir.z = Input.GetAxis("Vertical");


        if (Input.GetKeyDown(jumpkey) )
        {
            jump();
            _animation.SetTrigger(_Onjump);
            _isgrounded = false;
            
        }
    }

    public void onfixedupdate() 
    {
      playermovement.move(_dir.x, _dir.z);
    }
}
