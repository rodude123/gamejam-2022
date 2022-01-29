using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, IEnemyDamage
{

    [SerializeField] private GameObject _enemy;
    [SerializeField] private float _enemyHP;
    [SerializeField] private bool _enemyDeath;
    [SerializeField] private Image _healthBar;

    [SerializeField] private Score score;

    
    
    // Start is called before the first frame update
    void Start()
    {
        _enemy = this.gameObject;
        _enemyHP = 100;
        
        if (_enemy.CompareTag("TierOneEnemy"))
        {
            _enemyHP = 10;
        }
        
        if (_enemy.CompareTag("TierTwoEnemy"))
        {
            _enemyHP = 30;
        }
        
        if (_enemy.CompareTag("TierThreeEnemy"))
        {
            _enemyHP = 70;
        }
        
        if (_enemy.CompareTag("TierFourEnemy"))
        {
            _enemyHP = 100;
        }
        
        if (_enemy.CompareTag("TierFiveEnemy"))
        {
            _enemyHP = 200;
        }
        
        _enemyDeath = false;
    }
    #region Damage Recieved
    public void TypeOneDamage()
    {
        _enemyHP -= 10;
    }
    
    public void TypeTwoDamage()
    {
        _enemyHP -= 20;
    }
    
    public void TypeThreeDamage()
    {
        _enemyHP -= 30;
    }
    
    public void TypeFourDamage()
    {
        _enemyHP -= 40;
    }
    
    public void TypeFiveDamage()
    {
        _enemyHP -= 50;
    }
    
    public void TypeSixDamage()
    {
        _enemyHP -= 60;
    }
    
    public void TypeSevenDamage()
    {
        _enemyHP -= 80;
    }
    
    public void TypeEightDamage()
    {
        _enemyHP -= 100;
    }
    #endregion
    void Update()
    {
        if (_enemyHP <= 0)
        {
            Death();
        }

        #region Enemy Health Bar Filling

        if (_enemy.CompareTag("TierOneEnemy"))
        {
            _healthBar.fillAmount = _enemyHP / 10f;
        }
        
        if (_enemy.CompareTag("TierTwoEnemy"))
        {
            _healthBar.fillAmount = _enemyHP / 30f;
        }
        
        if (_enemy.CompareTag("TierThreeEnemy"))
        {
            _healthBar.fillAmount = _enemyHP / 70f;
        }
        
        if (_enemy.CompareTag("TierFourEnemy"))
        {
            _healthBar.fillAmount = _enemyHP / 100f;
        }
        
        if (_enemy.CompareTag("TierFiveEnemy"))
        {
            _healthBar.fillAmount = _enemyHP / 200f;
        }
        #endregion
    }

    // changes death bool to true, adds score on death, and destroys object
    void Death()
    {
        _enemyDeath = true;
        score.Tier1Enemy();
        Destroy(gameObject);
    }
}