using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class armas : MonoBehaviour
{
    [SerializeField] public float damage;
    [SerializeField] public float weaponspeed;
    [SerializeField] private int shootkey = 0;
    [SerializeField] protected float currentdamage;
    [SerializeField] protected float currentweaponspeed;

    [SerializeField] protected GameObject bullet;

    public void Update()
    {
        if (Input.GetMouseButtonDown(shootkey))
        {
            Instantiate(bullet,transform.position,transform.rotation);
        } 
    }

    public void Start()
    {
       
      
    }
   

  


}
