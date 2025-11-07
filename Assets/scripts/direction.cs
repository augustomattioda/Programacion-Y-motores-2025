using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class direction 
{
    [Header("Animator")]
    [SerializeField] private string _Onjump = "Onjump";

    public movement playermovement;

    private Animator _animation;

    private bool _isgrounded = true;

    KeyCode jumpkey = KeyCode.Space;
    Vector3 _dir;
    public direction(movement m, Animator a) 
    {
        playermovement = m;
        _animation = a;
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
            if (_animation)
            {
                _animation.SetTrigger(_Onjump);
                Debug.Log(_Onjump);
            }
            else 
            {
            
            }
            _isgrounded = false;
            
        }
    }

    public void onfixedupdate() 
    {
      playermovement.move(_dir.x, _dir.z);
    }
}
