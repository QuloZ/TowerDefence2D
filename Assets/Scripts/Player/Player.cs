﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour, ItakenDamage
{
    public GameControlls gameControlls;
    public UIManager uiManager;

    private int _health;
    private int _gold;
    private int _kills;


    void Start()
    {
        _health = gameControlls.GetPlayerHP;
        _gold = gameControlls.GetBaseGold;
    }

    public void AddFrag()
    {
        _kills++;
    }

    public void TakenReward(int reward)
    {
        _gold += reward;
        SendUI();
    }

    public void TakenDamage(int damage)
    {
        _health -= damage;
        isAlive();
    }

    public void isAlive()
    {
        if (_health <= 0)
        {
            _health = 0;
            uiManager.GameOver(_kills);
        }

        SendUI();
    }

   
    public void Buy(int value)
    {
        _gold -= value;
        SendUI();
    }

    private void SendUI() 
    {
        uiManager.SetGold(_gold);
        uiManager.SetHealth(_health);

    }
     public int Gold { get { return _gold; } }
}
