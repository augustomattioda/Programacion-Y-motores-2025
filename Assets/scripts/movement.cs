using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement 
{
    [Header("Animator")]
    [SerializeField] private string IsGrounded = "IsGrounded";
    [SerializeField] private string _Onjump = ":_Onjump";

    private float speed;

    Transform _transform;

    private Animator _animation;

    private Rigidbody _rb;

    private float _jumpforce;

    private bool _isgrounded = true;

    public movement(Transform t, float s, Rigidbody rb, float jf, Animator animator, bool ground)
    {
        _transform = t;
        speed = s;
        _rb = rb;
        _jumpforce = jf;
        _animation = animator;
        _isgrounded = ground;
    }

    private Vector3 _dir = new();

    public void move(float x, float z) 
    {
        _dir = (_transform.right * x + _transform.forward * z).normalized;
        _rb.MovePosition(_transform.position + _dir * speed * Time.fixedDeltaTime);
        _animation.SetFloat("Xaxis", x);
        _animation.SetFloat("Zaxis", z);
        _animation.SetBool(IsGrounded, _isgrounded);
    }
    
    
    public void jump() 
    {
         _rb.AddForce(_transform.up * _jumpforce, ForceMode.Impulse);
    }
  
}
