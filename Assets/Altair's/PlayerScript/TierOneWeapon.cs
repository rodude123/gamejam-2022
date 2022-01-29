using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TierOneWeapon : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        var damage = collision.gameObject.GetComponent<IEnemyDamage>();
        damage.TypeOneDamage();
    }
}
