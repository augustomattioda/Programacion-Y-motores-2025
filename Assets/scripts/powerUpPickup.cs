using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpPickup : MonoBehaviour
{
    public MonoBehaviour effectScript;

    private void OnTriggerEnter(Collider other)
    {
        entity target = other.GetComponent<entity>();
        if (target == null) return;

        powerUp effect = effectScript as powerUp;
        if (effect != null)
            effect.Apply(target);

        Destroy(gameObject);
    }
}
