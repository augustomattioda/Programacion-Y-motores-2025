using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class armas : MonoBehaviour
{
    [SerializeField] public float damage;
    [SerializeField] protected float currentdamage;
    [SerializeField] public float weaponspeed;
    [SerializeField] protected float currentweaponspeed;
    public GameObject bullet;
    public virtual void Shoot()
    {

    }
}
