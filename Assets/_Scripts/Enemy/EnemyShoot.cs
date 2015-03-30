using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {

    private WeaponBehaviour weapon;

    void Awake()
    {
        // Retrieve the weapon only once
        weapon = GetComponent<WeaponBehaviour>();
    }

    void Update()
    {
        // Auto-fire
        if (weapon != null && weapon.CanAttack)
        {
            weapon.Attack(true);
        }
    }
}