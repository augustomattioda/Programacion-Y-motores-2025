using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerinteraction : MonoBehaviour
{
    public class PlayerInteraction : MonoBehaviour
    {
        public float interactionRange = 3f;
        private interaction currentInteractable;

        void Update()
        {
            DetectInteractable();

            if (Input.GetKeyDown(KeyCode.E) && currentInteractable != null)
            {
               // currentInteractable.Interact();
            }
        }

        void DetectInteractable()
        {
            Ray ray = new Ray(transform.position, transform.forward);

            if (Physics.Raycast(ray, out RaycastHit hit, interactionRange))
            {
                currentInteractable = hit.collider.GetComponent<interaction>();
            }
            else
            {
                currentInteractable = null;
            }
        }
    }
}
