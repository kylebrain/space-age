using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class Damageable : MonoBehaviour
{
    protected abstract void DealDamage(int damageAmount);

    private void OnTriggerEnter(Collider other)
    {
        Weapon weapon = other.GetComponent<Weapon>();
        if (weapon != null && weapon.caster != this)
        {
            DealDamage(weapon.damageAmount);
            Destroy(other.gameObject);
        }
    }
}
