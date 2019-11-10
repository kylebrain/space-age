using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageable : Damageable
{
    protected override void DealDamage(int damageAmount, Damageable casted)
    {
        UserDamageManager.OnHit(damageAmount);
    }
}
