﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerUpgrade : MonoBehaviour
{
    [SerializeField] private int damageUP;
    [SerializeField] private float decreaseCooldown;
    [SerializeField] private int costUpStep;
    [SerializeField] private float minCooldown;
    private int costUP;
    private ATower tower;
    private int damage;
    private float cooldown;

    void Start()
    {
        tower = GetComponent<ATower>();
        damage = tower.Damage;
        cooldown = tower.BaseCooldown;
        costUP = costUpStep;
    }

    public void UpgradeDamage()
    {
        damage += damageUP;
        tower.Damage = damage;

        costUP += costUpStep;
    }

    public void UpgradeFireRate()
    {
        cooldown -= decreaseCooldown;
        if (cooldown < minCooldown)
        {
            cooldown = minCooldown;
        }
        tower.BaseCooldown = cooldown;

        costUP += costUpStep;
    }
    public bool CanUpdate()
    {
        if (cooldown > minCooldown)
        {           
            return true;
        }
        return false;
    }
    public int Costup { get { return costUP; } }
}
