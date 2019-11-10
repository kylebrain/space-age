using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class Damageable : MonoBehaviour
{
    protected abstract void DealDamage(int damageAmount, Damageable casted);

    private void OnTriggerEnter(Collider other)
    {
        Weapon weapon = other.GetComponent<Weapon>();
        if (weapon != null && weapon.caster != this)
        {
            DealDamage(weapon.damageAmount, weapon.caster);
            Destroy(other.gameObject);
        }
    }
}
