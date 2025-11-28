using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack
{
    [Header("Animator")]
    [SerializeField] private string OnAttack = "OnAttack";

    KeyCode attackkey = KeyCode.Mouse0;

    private Animator _animation;

    private armas armaequipada;

    armas[] armas;

    public attack(armas[] a, Animator B)
    {
        armas = a;
        switchweapon(0);
        
        _animation = B;
    }

    public void switchweapon(int tool)
    {
        armaequipada?.gameObject.SetActive(false);

        armaequipada = armas[tool];

        armaequipada.gameObject.SetActive(true);
    }

    public void weaponattack()
    {
        armaequipada.Shoot();
    }
    public void Onupdate() 
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            switchweapon(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            switchweapon(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            switchweapon(2);
        }

        if (Input.GetKeyDown(attackkey))
        {
            _animation.SetTrigger(OnAttack);
        }
        if (Input.GetMouseButtonDown(0)) 
        {
            weaponattack();
        }
       

    }

    
}
