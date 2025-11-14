using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistola : armas
{
    public override void Shoot()
    {
        Instantiate(bullet);
    }
}
