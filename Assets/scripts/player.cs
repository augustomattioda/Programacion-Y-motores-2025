using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : entity, iaffectedspeed
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
        playerdirection = new direction(playermovement, _animation);
    }

    private void Update()
    {
        playerdirection.onUpdate();
        DetectInteractable();

        if (Input.GetKeyDown(KeyCode.E) && currentInteractable != null)
        {
            currentInteractable.Interact();
        }
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


    public float interactionRange = 3f;
    private interaccion currentInteractable;

    void DetectInteractable()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, interactionRange))
        {
            currentInteractable = hit.collider.GetComponent<Interactable>();
        }
        else
        {
            currentInteractable = null;
        }
    }
}


