using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class interaccion : MonoBehaviour
{
    /*
    internal void Interact()
    {
        throw new NotImplementedException();
    }

    public abstract class AbstractInteractable : MonoBehaviour
    {
        public float interactDistance = 3f;
        public KeyCode interactKey;

        protected Camera cam;

        protected virtual void Start()
        {
            cam = Camera.main;
        }

        void Update()
        {
            if (Input.GetKeyDown(interactKey) && IsLookingAtMe())
            {
                Interact();
            }
        }

        bool IsLookingAtMe()
        {
            Ray ray = new Ray(cam.transform.position, cam.transform.forward);

            if (Physics.Raycast(ray, out RaycastHit hit, interactDistance))
            {
                return hit.collider.gameObject == this.gameObject;
            }

            return false;
        }

        public abstract void Interact();  // método obligatorio
    }
    */

}


