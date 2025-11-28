using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escopeta : armas
{
    public Transform[] pivotShoot;
    public override void Shoot()
    {
        foreach (Transform t in pivotShoot)
        {
            GameObject newbullet = Instantiate(bullet, t.position, t.rotation);
            newbullet.transform.up = -transform.forward;
        }
    }
}
    
