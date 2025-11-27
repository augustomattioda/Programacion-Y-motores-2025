using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedUP : MonoBehaviour
{
    public class SpeedPowerUp : MonoBehaviour, powerUp
    {
        public float speedBonus = 3f;

        public void Apply(entity target)
        {
            target.ApplySpeedModifier(speedBonus);
        }
    }
}
