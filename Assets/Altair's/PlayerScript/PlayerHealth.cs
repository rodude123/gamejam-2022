using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// tracks player's HP and whether the HP is zero or below. If HP below zero triggers _playerDead bool to true.
// Resets _playerDead to false when this script is instantiated.
// Reduces player HP if collided with enemy.

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float _playerHP;
    [SerializeField] private bool _playerDead;
    [SerializeField] private float _maxPlayerHP;
    [SerializeField] private float _playerHPRecoveryRate;
    [SerializeField] private float _collisionDamage;
    
    [SerializeField] private Image healthBar;
    [SerializeField] private Image healthCanvas;
    [SerializeField] private Canvas GameOverCanvas;

    void Start()
    {
        _player = this.gameObject;
        _playerHP = 100;
        _playerDead = false;
    }

    void Update()
    {
        
        healthBar.fillAmount = _playerHP / 100f;
 
        if (_playerHP <= 0)
        {
            Death();
        }
        
        if (_playerHP < _maxPlayerHP)
        {
            _playerHP += _playerHPRecoveryRate * Time.deltaTime;
        }
    }
    
    // damage list
    public void TierOneEnemyTakeDamage()
    {
        _playerHP += 5;
    }
    public void TierTwoEnemyTakeDamage()
    {
        _playerHP += 15;
    }
    public void TierThreeEnemyTakeDamage()
    {
        _playerHP += 30;
    }
    public void TierFourEnemyTakeDamage()
    {
        _playerHP += 50;
    }
    public void TierFiveEnemyTakeDamage()
    {
        _playerHP += 100;
    }

    public void EnemyCollisionDamage()
    {
        _playerHP += _collisionDamage * Time.deltaTime;
    }

    // health recovery list
    

    void Death()
    {
        _playerDead = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            _playerHP -= _collisionDamage * Time.deltaTime;
            Debug.Log("Collision");
        }
    }

    public void HealthRecovery()
    {
        if (_playerHP > 90)
        {
            _playerHP = 100;
        }
        else
        {
            _playerHP += 10;
        }
    }
}
