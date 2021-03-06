﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ATower : MonoBehaviour
{
    [SerializeField] private float _range;
    [SerializeField] private int _damage;
    [SerializeField] private float _baseCooldown;
    [SerializeField] private string _name;
    [SerializeField] private int _price;
    [SerializeField] private int _layerMask;
    [SerializeField] private GameObject _bulletPrefab;
    private float _cooldown;

    private void Start()
    {
        GetComponent<SearchTarget>().SetTargetData(_range, _layerMask);
        GetComponent<Shooting>().SetShootData(_baseCooldown, _bulletPrefab);
    }
    /*  void Update()
      {
          if (CanShoot())
          {
              SearchTarget();
          }

          if (_cooldown > 0)
          {
              _cooldown -= Time.deltaTime;
          }
      }

      bool CanShoot() 
      {
          if (_cooldown <=0)
          {
              return true;
          }
          return false;
      } 

      void SearchTarget()
      {
          Transform target = null;
          float targetDistance = Mathf.Infinity;

          foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
          {
              float currentDistance = Vector2.Distance(transform.position, enemy.transform.position);

              if (currentDistance < targetDistance && currentDistance < _range)
              {
                  target = enemy.transform;
                  targetDistance = currentDistance;
              }
          }

          if (target!=null)
          {
              Shoot(target);
          }
      }

      void Shoot(Transform target)
      {
          _cooldown = _baseCooldown;
          target.gameObject.GetComponent<AEnemy>().TakenDamage(_damage);
      }
      */
    public int Damage { get { return _damage; } set { _damage = value; } }
    public int GetPrice { get { return _price; } }
    public string GetName { get { return _name; } }
    public float BaseCooldown { get { return _baseCooldown; } set { _baseCooldown = value; } }
}
