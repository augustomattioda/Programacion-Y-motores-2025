using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistola : armas
{
    public override void Shoot()
    {

        GameObject newbullet = Instantiate(bullet,transform.position,Quaternion.identity);
        newbullet.transform.up = -transform.forward;
    }
}
